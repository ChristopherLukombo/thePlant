using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.dao;

namespace ThePlant.Business
{
	public abstract class Factory
	{
		public static ICommandDAO GetCommandDAO()
		{
			return new CommandDAOImpl();
		}

		public static IPlantDAO GetPlantDAO()
		{
			return new PlantDAOImpl();
		}
	}
}
