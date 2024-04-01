using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControllSystem.Momento
{
    public interface IMomonto
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}
