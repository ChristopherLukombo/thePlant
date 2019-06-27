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

		public StateEnum StateEnum { get; set; }

		// paypal or other
		public string ChoicePaiment { get; set; }

		public List<PlantModel> Plants { get; set; }
        public List<IProduct> Options { get; set; }
    }
}
