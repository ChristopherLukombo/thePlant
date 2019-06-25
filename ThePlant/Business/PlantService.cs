using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Entity;

namespace ThePlant.Business
{
	interface PlantService
	{
		List<PlantModel> findAll();
	}
}
