using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Entity;

namespace ThePlant.dao
{
	public interface IPlantDAO
	{
		List<PlantModel> findAll();
	}
}
