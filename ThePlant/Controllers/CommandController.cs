using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Business;
using ThePlant.Business.dto;
using ThePlant.Business.impl;

namespace ThePlant.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class CommandController : ControllerBase
    {
        private ICommandService commandService;

        public CommandController()
        {
            this.commandService = new CommandServiceImpl();
        }

        /*[HttpGet]
        [Route("commands")]
        public ActionResult<IEnumerable<CommandModelDTO>> GetAllCommands()
        {
            return this.commandService.FindAll();
        }

        [HttpGet]
        [Route("plant/{id}")]
        public ActionResult<PlantModelDTO> GetById(int id)
        {
            return this.plantService.FindById(id);
        }*/

        [HttpPost]
        [Route("commands")]
        public ActionResult<PlantModelDTO> AddCommand(CommandModelDTO commandModel)
        {
            if (commandModel == null)
                return BadRequest("Error : null parameter for command model.");

            CommandModelDTO result = this.commandService.AddPlant(plantModel);

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
