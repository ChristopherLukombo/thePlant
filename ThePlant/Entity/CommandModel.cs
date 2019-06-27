using System;
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

		public StateEnum StateEnum { get; set; }

		public string ChoicePaiment { get; set; }

		public List<PlantModel> Plants { get; set; }
        public List<IProduct> Options { get; set; }

		public void Execute()
		{
			State.Execute(this);
		}

	}
}
