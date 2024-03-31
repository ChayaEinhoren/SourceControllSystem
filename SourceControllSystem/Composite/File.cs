using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem.Composite
{
    public class File : ITree
    {
        public string Execute()
        {
            return "file";
        }
    }
}
