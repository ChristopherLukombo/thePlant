﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThePlant.Business;
using ThePlant.Business.dto;
using ThePlant.Business.impl;
using ThePlant.Entity;

namespace ThePlant.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class PlantsController : ControllerBase
    {
		private IPlantService plantService;

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
        public ActionResult<IEnumerable<PlantModelDTO>> GetAllPlants()
        {
			return this.plantService.FindAll();
		}

        [HttpGet]
        [Route("plant/{id}")]
        public ActionResult<PlantModelDTO> GetById(int id)
        {
            return this.plantService.FindById(id);
        }

        [HttpPost]
        [Route("plants")]
        public ActionResult<PlantModelDTO> AddPlant(PlantModelDTO plantModel)
        {
            if (plantModel == null)
                return BadRequest("Error : null parameter for plant model.");

            PlantModelDTO result = this.plantService.AddPlant(plantModel);

            if (result == null)
                return BadRequest("Error when adding the plant with id : " + plantModel.Id);

            return result;
        }

        [HttpPut]
        [Route("plants")]
        public ActionResult<PlantModelDTO> UpdatePlant(PlantModelDTO plantModel)
        {
            if (plantModel == null)
                return BadRequest("Error : null parameter for plant model.");

            PlantModelDTO result = this.plantService.UpdatePlant(plantModel);

            if (result == null)
                return BadRequest("Error when updating the plant with id : " + plantModel.Id);

            return result;
        }

        [HttpDelete]
        [Route("plant/{id}")]
        public ActionResult DeletePlant(int id)
        {
            if (id <= 0)
                return BadRequest("Error : null parameter for plant model.");

            bool result = this.plantService.DeletePlant(id);

            if (!result)
                return BadRequest("Error when deleting the plant with id : " + id);

            return Ok();
        }
    }
}
