using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem
{
    public class Task
    {
        public IState status { get; set; }
        public Task() {
            status = new Draft();
        }
    }
}
