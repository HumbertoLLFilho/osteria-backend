using Osteria.Backend.Core.Models.Base;
using Osteria.Backend.Core.Enums;

namespace Osteria.Backend.Core.Models
{
    public class Reserve : BaseEntity
    {
        public User Owner { get; set; } = new();
        public Guid OwnerID { get; set; }

        public List<Table> Table { get; set; } = new();

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int People { get; set; }
        public DateTime Date { get; set; }
        
        public Reserve(Guid ownerID, DateTime date) 
        {
            OwnerID = ownerID;
            Date = date;
        }

        public void AddPeople(int peopleToAdd)
        {
            People += peopleToAdd;
        }

        public bool RemovePeople(int peopleToRemove)
        {
            var people = People - peopleToRemove;

            var isValid = people < 1 ? false : true;

            if(isValid)
                People = people;

            return isValid;
        }

        public void UpdatePeople(int people, Operation operation)
        {
            if(operation == Operation.Add)
                AddPeople(people);
            else if(operation == Operation.Remove)
                RemovePeople(people);

            Update();
        }

        public override void Update()
        {
            base.Update();
        }
    }
}
