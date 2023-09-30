using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.Storage.Queue.Protocol;

namespace ContactFunction
{
    public static class FunctionContactUs
    {
        [FunctionName("ContactUs")]
        public static void Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            [CosmosDB(
                databaseName: "ToDoItems",
                containerName: "Items",
                Connection = "CosmosDBConnection")]out ContactModel document,
        ILogger log)
        {
            
            string requestBody =  new StreamReader(req.Body).ReadToEnd();
            log.LogDebug(requestBody);
            var data = JsonConvert.DeserializeObject<ContactModel>(requestBody);

            document = data;
            log.LogInformation("Successfully saved in CosmosDB");
        }
    }
}
