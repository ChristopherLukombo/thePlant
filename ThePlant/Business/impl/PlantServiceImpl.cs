using System;


using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThePlant.Entity;



namespace ThePlant.Business.impl
{
	public class PlantServiceImpl : PlantService
	{
		public List<PlantModel> findAll()
		{
			PlantModel plant1 = new PlantModel() { Name = "Plant numero 1", Price = 10 };
			PlantModel plant2 = new PlantModel() { Name = "Plant numero 2", Price = 9.50 };

			List<PlantModel> plants = new List<PlantModel>();
			plants.Add(plant1);
			plants.Add(plant2);

			return plants;
		}
	}
}
