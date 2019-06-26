using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Business.dto;
using ThePlant.Entity;

namespace ThePlant.Business
{
	public interface IPlantService
	{
		List<PlantModelDTO> FindAll();
        PlantModelDTO FindById(int id);

        PlantModelDTO AddPlant(PlantModelDTO plantModel);
        PlantModelDTO UpdatePlant(PlantModelDTO plantModel);
        bool DeletePlant(int id);
	}
}
