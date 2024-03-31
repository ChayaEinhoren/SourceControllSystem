using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem.State
{
    public class Merge : IState
    {
        public void ChangeState(Task state)
        {
            Console.WriteLine("merged already...");
        }

        public void GetState()
        {
            Console.WriteLine("Merge");
        }
    }
}
