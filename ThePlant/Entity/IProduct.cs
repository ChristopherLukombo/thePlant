﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePlant.Entity
{
	public interface IProduct
	{
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
    }
}
