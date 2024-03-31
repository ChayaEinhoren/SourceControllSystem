using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem
{
    public class ReadyToMerge : IState
    {
        public void ChangeState(Task state)
        {
            state.status = new Merge();
        }

        public void GetState()
        {
            Console.WriteLine("ReadyToMerge");
        }
    }
}
