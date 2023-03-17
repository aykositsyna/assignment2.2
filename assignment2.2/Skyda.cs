using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._2
{ 
    delegate void ProtectionFallHandler(object, ProtectionFallEventArgs)
    internal class Skyda
    {
        public int KnownFalledProtectionLayersNumber;
        public ProtectionSystem ProtectionSystem;
        public ProtectionFallHandler ProtectionFall;

        public virtual void NotifyProtectionFall()
        { }

        public virtual void Attack()
        { }
    }
}
