using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Business.dto;
using ThePlant.Entity;

namespace ThePlant.Business
{
	public interface ICommandService
	{
		//void AddPlant(PlantModel plant);
		//void AddOption(IProduct product);

		CommandModelDTO SavePayment(CommandModelDTO commandModelDTO);

		CommandModelDTO Pay(CommandModelDTO commandModelDTO);
	}
}
