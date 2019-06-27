﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Entity;

namespace ThePlant.Business
{
	public class FinishedState : IStateCommand
	{
		public void Execute(CommandModel command)
		{
			command.StateEnum = StateEnum.Finished;
		}
	}
}
