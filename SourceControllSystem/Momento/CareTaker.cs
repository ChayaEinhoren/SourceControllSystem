using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem.Momento
{
    public class CareTaker
    {
        private List<IMemento> mementos = new List<IMemento>();

        private Originator originator = null;

        public CareTaker(Originator originator)
        {
            this.originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("\nCaretaker: Saving Originator's state...");
            this.mementos.Add(this.originator.Save());
        }

        public void Undo()
        {
            if (this.mementos.Count == 0)
            {
                return;
            }

            var memento = this.mementos.Last();
            this.mementos.Remove(memento);

            Console.WriteLine("Caretaker: Restoring state to: " + memento.GetName());

            try
            {
                this.originator.Restore(memento);
            }
            catch (Exception)
            {
                this.Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of _mementos:");

            foreach (var memento in this.mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
