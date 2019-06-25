using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThePlant.Business;
using ThePlant.Business.impl;
using ThePlant.Entity;

namespace ThePlant.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
		private PlantService plantService;

		public PlantsController()
		{
			this.plantService = new PlantServiceImpl();
		}

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
			return this.plantService.findAll();
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
