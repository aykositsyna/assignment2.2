using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._2
{
    public class ProtectionFallEventArgs : EventArgs
    {
        public int FalledProtectionLayersNumber;
        public ProtectionSystem System;

        public ProtectionFallEventArgs(int falledProtectionLayersNumber, ProtectionSystem system)
        {
            FalledProtectionLayersNumber = falledProtectionLayersNumber;
            System = system;
        }
    }
}
