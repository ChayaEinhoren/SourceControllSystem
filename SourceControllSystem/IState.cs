﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem
{
    public interface IState
    {
        public void GetState();
        public void ChangeState(Task state);
    }
}
