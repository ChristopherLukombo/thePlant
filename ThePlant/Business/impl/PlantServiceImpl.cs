using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThePlant.Business.dto;
using ThePlant.Business.mapper;
using ThePlant.Entity;

namespace ThePlant.Business.impl
{
	public class PlantServiceImpl : IPlantService
	{
        PlantMapperImpl plantMapperImpl = new PlantMapperImpl();

        public List<PlantModelDTO> FindAll()
		{
			PlantModel plant1 = new PlantModel() { Id = 1, Name = "Plant numero 1", Price = 10 };
			PlantModel plant2 = new PlantModel() { Id = 2, Name = "Plant numero 2", Price = 9.50 };

			List<PlantModel> plants = new List<PlantModel>();
			plants.Add(plant1);
			plants.Add(plant2);

            return plants.Select(x => plantMapperImpl.ToDTO(x)).ToList();
		}

        public PlantModelDTO FindById(int id)
        {
            List<PlantModelDTO> plants = FindAll();

            return plants.Where(x => x.Id == id).FirstOrDefault();
        }

        public PlantModelDTO AddPlant(PlantModelDTO plantModel)
        {
            List<PlantModelDTO> plants = FindAll();

            plants.Add(plantModel);

            return plantModel;
        }

        public PlantModelDTO UpdatePlant(PlantModelDTO plantModel)
        {
            List<PlantModelDTO> plants = FindAll();

            int index = plants.Select(x => x.Id).ToList().IndexOf(plantModel.Id);

            if (index == -1)
                return null;

            plants.RemoveAt(index);
            plants.Insert(index, plantModel);

            return plantModel;
        }

        public bool DeletePlant(int id)
        {
            List<PlantModelDTO> plants = FindAll();

            int index = plants.Select(x => x.Id).ToList().IndexOf(id);

            if (index == -1)
                return false;

            plants.RemoveAt(index);

            return true;
        }
    }
}
