using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Business.dto;
using ThePlant.Entity;

namespace ThePlant.Business.mapper
{
	public class CommandMapperImplWithList : ICommandMapper
	{
		public CommandModelDTO ToDTO(CommandModel commandModel)
		{
			CommandModelDTO commandModelDTO = new CommandModelDTO();
			commandModelDTO.Id = commandModel.Id;
			commandModelDTO.CreatedAt = commandModel.CreatedAt;
			commandModelDTO.StateEnum = commandModel.StateEnum;
			commandModelDTO.ChoicePaiment = commandModel.ChoicePaiment;

			List<PlantModelDTO> plantsDTO = new List<PlantModelDTO>();
			foreach (var p in commandModel.Plants)
			{
				PlantModelDTO plantModelDTO = new PlantModelDTO();
				plantModelDTO.Id = p.Id;
				plantModelDTO.Name = p.Name;
				plantModelDTO.Price = p.Price;
				plantModelDTO.Type = p.Type;

				plantsDTO.Add(plantModelDTO);
			}

			commandModelDTO.Plants = plantsDTO;

			return commandModelDTO;
		}

		public CommandModel ToEntity(CommandModelDTO commandModelDTO)
		{
			CommandModel commandModel = new CommandModel();
			commandModel.Id = commandModelDTO.Id;
			commandModel.CreatedAt = commandModelDTO.CreatedAt;
			commandModel.StateEnum = commandModelDTO.StateEnum;
			commandModel.ChoicePaiment = commandModelDTO.ChoicePaiment;

			List<PlantModel> plants = new List<PlantModel>();
			foreach (var p in commandModelDTO.Plants)
			{
				PlantModel plantModel = new PlantModel();
				plantModel.Id = p.Id;
				plantModel.Name = p.Name;
				plantModel.Price = p.Price;
				plantModel.Type = p.Type;

				plants.Add(plantModel);
			}

			commandModel.Plants = plants;

			return commandModel;
		}
	}
}
