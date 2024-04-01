using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceControllSystem.Composite;
using SourceControllSystem.Observer;

namespace SourceControllSystem.State
{
    public class Task1
    {
        private List<IObserver> observers = new List<IObserver>();
        public IState status { get; set; }
        public Task1()
        {
            status = new Draft();
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
            Console.WriteLine("Added to observers...");
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public IState GetState()
        {
            return status;
        }
    }
}
