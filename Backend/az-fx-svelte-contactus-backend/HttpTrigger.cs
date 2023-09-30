using System.Net;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace ContactUsWebFn
{
    public class MultiResponse
    {
        [CosmosDBOutput( "Contacts-DB",  "containercont",
            Connection = "%CosmosDbConnectionString%", CreateIfNotExists = false)]
        public ContactDoc Document { get; set; }
        public HttpResponseData HttpResponse { get; set; }
    }
    public class ContactDoc {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }

    public class HttpTrigger
    {
        private readonly ILogger _logger;

        public HttpTrigger(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<HttpTrigger>();
        }

        [Function("HttpTrigger")]
        public MultiResponse Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req,
            FunctionContext executionContext
        )
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");

            var message = "Welcome to Azure Functions!";

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString(message);

            return new MultiResponse()
            {
                Document = new ContactDoc
                {
                    Id = System.Guid.NewGuid().ToString(),
                    Title = "Topic ex",
                    Message = message
                },
                HttpResponse = response
            };
        }
    }
}
