using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_session1_asssignment
{
    [Flags]
    enum Permissions : byte
    {
        Read=1, 
        write=3, 
        Delete=4, 
        Execute=8

    }
}
