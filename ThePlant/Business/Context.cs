using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePlant.Business
{
	public class Context
	{
		public IPaiement paiement { get; set; }

		public void Pay()
		{
			paiement.Pay();
		}
	}
}
