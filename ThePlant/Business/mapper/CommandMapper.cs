using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Business.dto;
using ThePlant.Entity;

namespace ThePlant.Business.mapper
{
	public interface CommandMapper
	{
		CommandModel ToEntity(CommandModelDTO commandModelDTO);

		CommandModelDTO ToDTO(CommandModel commandModel);
	}
}
