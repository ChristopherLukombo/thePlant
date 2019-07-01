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

			PlantModel plant1 = new PlantModel() { Id = 3, Name = "Plant numero 3", Price = 10, Type = "Sauvage" };
			PlantModel plant2 = new PlantModel() { Id = 4, Name = "Plant numero 4", Price = 9.50, Type = "Fragile" };

			plantModels.Add(plant1);
			plantModels.Add(plant2);

			return plantModels;
		}
	}
}
