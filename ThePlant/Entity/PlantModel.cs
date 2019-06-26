using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePlant.Entity
{
    public class PlantModel : IProduct
    {
        public PlantModel()
        {
        }

        public PlantModel(int id, string name, double price, string type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string Type { get; set; }
    }
}
