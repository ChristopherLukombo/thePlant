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
		public PlantModelDTO ToDTO(PlantModel plant)
		{
			PlantModelDTO plantDTO = new PlantModelDTO();
			plantDTO.Name = plant.Name;
			plantDTO.Price = plant.Price;
			plantDTO.Type = plant.Type;
			return plantDTO;
		}

		public PlantModel ToEntity(PlantModelDTO plantDTO)
		{
			PlantModel plant = new PlantModel();
			plant.Name = plantDTO.Name;
			plant.Price = plantDTO.Price;
			plant.Type = plantDTO.Type;
			return plant;
		}
	}
}
