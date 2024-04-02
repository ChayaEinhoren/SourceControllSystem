using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem.Composite
{
    public class Folder : IFile
    {
        public string Execute()
        {
            return "folder";
        }
    }
}
