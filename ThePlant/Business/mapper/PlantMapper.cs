using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Business.dto;
using ThePlant.Entity;

namespace ThePlant.Business.mapper
{
	public interface PlantMapper
	{
		PlantModel ToEntity(PlantModelDTO plantDTO);

		PlantModelDTO ToDTO(PlantModel plant);
	}
}
