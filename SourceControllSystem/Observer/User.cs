using SourceControllSystem.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem.Observer
{
    public class User : IObserver
    {
        public void Update(Task1 task)
        {
            Console.WriteLine(task.GetState());
        }
    }
}
