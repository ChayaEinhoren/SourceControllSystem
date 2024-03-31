using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem
{
    public class Draft : IState
    {
    
        public void ChangeState(Task state)
        {
           
        }


        public void GetState()
        {
            Console.WriteLine("Draft");
        }
    }
}
