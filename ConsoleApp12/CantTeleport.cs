using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class CantTeleport : Teleports
    {
        public string teleport()
        {
            return "Fails at Teleporting";
        }
    }
}
