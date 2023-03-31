using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._2
{
    internal class EndLayerNotifier : IReactProtectionFall
    {
        public int LayerReactorNumber { get; set; }

        public EndLayerNotifier()
        {
            LayerReactorNumber = 0;
        }

        public string Message { get; set; }
        public void OnProtectionFall(object sender, ProtectionFallEventArgs container)
        {
            if (container.FalledProtectionLayersNumber == 3)
            {
                Message = "Final layer is broken\n" + "Date:   " + container.System.Date.ToString() + "\nLayer number:   " +
                    container.FalledProtectionLayersNumber + "\nDays since start:   " + container.System.days;
            }
        }
    }
}
