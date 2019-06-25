using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Entity;

namespace ThePlant.Business
{
	interface PlantService
	{
		List<PlantModel> FindAll();
        PlantModel FindById(int id);

        PlantModel AddPlant(PlantModel plantModel);
        PlantModel UpdatePlant(PlantModel plantModel);
        bool DeletePlant(int id);
	}
}
