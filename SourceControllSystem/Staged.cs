using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem
{
    public class Staged : IState
    {
        public void ChangeState(Task state)
        {
            state.status = new Committed();
        }

        public void GetState()
        {
            Console.WriteLine("Staged");
        }
    }
}
