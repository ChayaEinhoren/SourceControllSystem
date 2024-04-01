using SourceControllSystem.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem.Composite
{
    public class Branch : ITree, IPrototype
    {
        List<ITree> children = new List<ITree>();
        public Branch() { }

        public Branch(Branch b)
        {
            this.children = b.children;
        }

        public void AddChild(ITree child)
        {
            children.Add(child);
        }
        public void RemoveChild(ITree child)
        {
            children.Remove(child);
        }

        public void GetChildren()
        {
            foreach (ITree child in children)
            {
                child.Execute();
            }
        }

        public string Execute()
        {
            string s = "Branch(";
            int i = 0;
            foreach (ITree child in children)
            {
                s += child.Execute();
                if (i < (children.Count - 1))
                {
                    s += " + ";
                }
                i++;
            }
            s += ")";
            return s;
        }

        public IPrototype CreateBranch()
        {
            return new Branch(this);
        }
    }
}
