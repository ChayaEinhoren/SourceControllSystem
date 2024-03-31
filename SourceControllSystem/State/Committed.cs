using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem.State
{
    public class Committed : IState
    {
        public void ChangeState(Task state)
        {
            state.status = new UnderReview();
        }

        public void GetState()
        {
            Console.WriteLine("Committed");
        }
    }
}
