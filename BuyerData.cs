using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using AppFrontEnd;

namespace VehicleVannaHomework
{
    public static class BuyerData
    {
        [FunctionName("BuyerData")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [Queue("VehicleData")] IAsyncCollector<VehicleData> vehicleQueue,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");


            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var vehicle = JsonConvert.DeserializeObject<VehicleData>(requestBody);
            await vehicleQueue.AddAsync(vehicle);

            log.LogInformation($"Buyer {vehicle.lastName}, {vehicle.firstName}");

            string responseMessage = $"Buyer {vehicle.firstName} {vehicle.firstName} ({vehicle.email}) purchased a {vehicle.year}" +
                $" {vehicle.make} {vehicle.modle} {vehicle.vehType} with list price of " +
                $"{vehicle.listPrice.ToString("C")}.With discount applied, purchase price is {(vehicle.listPrice-(vehicle.listPrice * .085m)).ToString("C")}";
            return new OkObjectResult(responseMessage);
        }
    }
}
