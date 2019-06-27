﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThePlant.Entity;

namespace ThePlant.Business
{
    public interface IStateCommand
    {
        void Execute(CommandModel command);
    }
}
