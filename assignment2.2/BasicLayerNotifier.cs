using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._2
{
    internal class BasicLayerNotifier : IReactProtectionFall
    {
        public int LayerReactorNumber { get; set; }

        public string Message { get; set; }
        public void OnProtectionFall(object sender, ProtectionFallEventArgs container)
        {
            if (container.FalledProtectionLayersNumber < 3)
            {
                Message = "Layer is broken\n" + "Date:   " + container.System.Date.ToString() + "\nLayer number:   " +
                    container.FalledProtectionLayersNumber;
            }
        }
        public void Subscribe(Skyda skyda)
        {
            skyda.ProtectionFall += OnProtectionFall;
        }

    }
}
