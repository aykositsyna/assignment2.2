using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._2
{
<<<<<<< HEAD
    public class Skyda
    {
        public int FalledProtectionLayersNumber { get; set; }
=======
    delegate void ProtectionFallHandler(object, ProtectionFallEventArgs );
    internal class Skyda
    {
        public int KnownFalledProtectionLayersNumber;
        public ProtectionSystem ProtectionSystem;
        public ProtectionFallHandler ProtectionFall;

        public virtual void NotifyProtectionFall()
        { }

        public virtual void Attack()
        {
            ProtectionSystem.GetAttack();
        }
>>>>>>> master
    }
}
