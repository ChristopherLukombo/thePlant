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
			if (DateTime.Now.ToString("HH") == "08")
			{
				return new PlantDAOImpl();
			}
			else
			{
				return new PlantDAOImpl2();
			}
		}
	}
}
