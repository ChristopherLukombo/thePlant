using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Business.dto;
using ThePlant.Entity;

namespace ThePlant.Business.mapper
{
	public class PlantMapperImpl : PlantMapper
	{
		public PlantDTO toDTO(PlantModel plant)
		{
			PlantDTO plantDTO = new PlantDTO();
			plantDTO.Name = plant.Name;
			plantDTO.Price = plant.Price;
			return plantDTO;
		}

		public PlantModel toEntity(PlantDTO plantDTO)
		{
			PlantModel plant = new PlantModel();
			plant.Name = plantDTO.Name;
			plant.Price = plantDTO.Price;
			return plant;
		}
	}
}
