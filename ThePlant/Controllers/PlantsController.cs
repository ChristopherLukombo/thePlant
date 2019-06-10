using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThePlant.Entity;

namespace ThePlant.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
        // GET api/v1/health
        [HttpGet]
        [Route("health")]
        public ActionResult<string> GetHealth()
        {
            return "Status : OK";
        }

        // GET api/v1/plants
        [HttpGet]
        [Route("plants")]
        public ActionResult<IEnumerable<PlantModel>> GetAllPlants()
        {
            PlantModel plant1 = new PlantModel() { Name = "Plant numero 1", Price = 10 };
            PlantModel plant2 = new PlantModel() { Name = "Plant numero 2", Price = 9.50 };

            List<PlantModel> plants = new List<PlantModel>();
            plants.Add(plant1);
            plants.Add(plant2);

            return plants;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
