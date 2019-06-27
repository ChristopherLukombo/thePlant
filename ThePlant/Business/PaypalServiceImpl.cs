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
			// TODO : payer par paypal
			Console.WriteLine("Payé par Paypal");
		}
	}
}
