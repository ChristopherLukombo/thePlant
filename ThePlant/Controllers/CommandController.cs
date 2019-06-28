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

		[HttpPost]
		[Route("commands")]
		public ActionResult<CommandModelDTO> CreatePayment(CommandModelDTO commandModelDTO)
		{
		   return this.commandService.SavePayment(commandModelDTO);
		}

		[HttpPost]
		[Route("commands/pay")]
		public ActionResult<CommandModelDTO> DoPayment(CommandModelDTO commandModelDTO)
		{
			return this.commandService.Pay(commandModelDTO);
		}


	}
}