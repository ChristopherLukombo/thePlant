﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Business;

namespace ThePlant.Entity
{
	public class CommandModel
	{
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public IStateCommand State { get; set; }

		public List<PlantModel> Plants { get; set; }
        public List<IProduct> Options { get; set; }
	}
}
