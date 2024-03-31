using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem
{
    public class Merge : IState
    {
        public void ChangeState(IState state)
        {
            throw new NotImplementedException();
        }

        public void GetState()
        {
            Console.WriteLine("Merge");
        }
    }
}
