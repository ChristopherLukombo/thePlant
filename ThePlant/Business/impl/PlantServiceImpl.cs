using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThePlant.Business.dto;
using ThePlant.Business.mapper;
using ThePlant.dao;
using ThePlant.Entity;

namespace ThePlant.Business.impl
{
	public class PlantServiceImpl : IPlantService
	{
        private PlantMapperImpl plantMapperImpl;

		public PlantServiceImpl()
		{
			plantMapperImpl = new PlantMapperImpl();
		}

		public List<PlantModelDTO> FindAll()
		{
			return Factory.GetPlantDAO().findAll()
				.Select(x => plantMapperImpl.ToDTO(x)).ToList();
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
