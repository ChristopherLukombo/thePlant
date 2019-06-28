using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThePlant.Business
{
	public class PaypalServiceImpl : IPaiement
	{
		public void Pay()
		{
			Console.WriteLine("Payé par Paypal");
		}
	}
}
