using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Business.dto;
using ThePlant.Entity;

namespace ThePlant.Business.mapper
{
	public class CommandMapperImpl : CommandMapper
	{
		public CommandModelDTO ToDTO(CommandModel commandModel)
		{
			CommandModelDTO commandModelDTO = new CommandModelDTO();
			commandModelDTO.Id = commandModel.Id;
			commandModelDTO.CreatedAt = commandModel.CreatedAt;
			commandModel.StateEnum = commandModelDTO.StateEnum;
			commandModel.ChoicePaiment = commandModelDTO.ChoicePaiment;
			return commandModelDTO;
		}

		public CommandModel ToEntity(CommandModelDTO commandModelDTO)
		{
			CommandModel commandModel = new CommandModel();
			commandModel.Id = commandModelDTO.Id;
			commandModel.CreatedAt = commandModelDTO.CreatedAt;
			commandModel.StateEnum = commandModelDTO.StateEnum;
			commandModel.ChoicePaiment = commandModelDTO.ChoicePaiment;
			return commandModel;
		}
	}
}
