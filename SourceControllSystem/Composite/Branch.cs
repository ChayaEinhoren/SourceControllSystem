using SourceControllSystem.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem.Composite
{
    public class Branch :  IPrototype
    {
        List<IFile> children = new List<IFile>();
        public Branch() { }

        public Branch(Branch b)
        {
            this.children = b.children;
        }

        public void AddChild(IFile child)
        {
            children.Add(child);
        }
        public void RemoveChild(IFile child)
        {
            children.Remove(child);
        }

       /* public void GetChildren()
        {
            foreach (IFile child in children)
            {
                child.Execute();
            }
        }*/

        public string GetChildren()
        {
            string s = "Branch(";
            int i = 0;
            foreach (IFile child in children)
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
