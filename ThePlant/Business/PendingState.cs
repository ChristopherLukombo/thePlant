using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Entity;

namespace ThePlant.Business
{
    public class PendingState : IStateCommand
    {
        public void SetState(CommandModel command)
        {


            Console.WriteLine("Pending");
        }
    }
}
