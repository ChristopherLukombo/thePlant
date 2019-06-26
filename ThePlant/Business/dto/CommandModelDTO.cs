using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Entity;

namespace ThePlant.Business.dto
{
    public class CommandModelDTO
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<PlantModel> Plants { get; set; }
        public List<IProduct> Options { get; set; }
    }
}
