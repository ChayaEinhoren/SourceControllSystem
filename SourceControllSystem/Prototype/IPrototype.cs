﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem.Prototype
{
    public interface IPrototype
    {
        IPrototype CreateBranch();
    }
}
