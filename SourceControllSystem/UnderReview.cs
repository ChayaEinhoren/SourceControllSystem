using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem
{
    public class UnderReview : IState
    {
        public void ChangeState(Task state)
        {
            state.status = new ReadyToMerge();
        }

        public void GetState()
        {
            Console.WriteLine("UnderReview");
        }
    }
}
