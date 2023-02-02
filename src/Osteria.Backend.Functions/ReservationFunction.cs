using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Osteria.Backend.Functions
{
    public class ReservationFunction
    {
        private readonly ILogger _logger;

        public ReservationFunction(ILoggerFactory loggerFactory, IReservationService reservationService)
        {
            _logger = loggerFactory.CreateLogger<ReservationFunction>();
        }

        [Function("ReservationFunction")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Welcome to Azure Functions!");

            return response;
        }
    }
}
