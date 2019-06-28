using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Entity;

namespace ThePlant.dao
{
	public class PlantDAOImpl2 : IPlantDAO
	{
		public List<PlantModel> FindAll()
		{
			List<PlantModel> plantModels = new List<PlantModel>();

			PlantModel plant1 = new PlantModel() { Id = 1, Name = "Plant numero 7", Price = 10 };
			PlantModel plant2 = new PlantModel() { Id = 2, Name = "Plant numero 1", Price = 9.50 };

			plantModels.Add(plant1);
			plantModels.Add(plant2);

			return plantModels;
		}
	}
}
