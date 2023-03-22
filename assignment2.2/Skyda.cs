using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._2
{
    public delegate void ProtectionFallHandler(object sender, ProtectionFallEventArgs container);
    public class Skyda
    {
        public int FalledProtectionLayerNumber;
        public int KnownFalledProtectionLayersNumber;
        public ProtectionSystem ProtectionSystem;
        public event ProtectionFallHandler ProtectionFall;

        public virtual void NotifyProtectionFall()
        {
            ProtectionSystem.ProtectionCheck(KnownFalledProtectionLayersNumber);
            ProtectionFallEventArgs protectionFallEventArgs = new ProtectionFallEventArgs(FalledProtectionLayerNumber, ProtectionSystem);
            object empty = new Object();
            ProtectionFall(empty, protectionFallEventArgs);
        }

        public virtual void Attack()
        {
            ProtectionSystem.GetAttack();
        }

    }
}
