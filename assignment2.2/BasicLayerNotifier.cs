using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._2
{
    internal class BasicLayerNotifier : IReactProtectionFall
    {
        public BasicLayerNotifier(int layerReactNumber)
        {
            LayerReactNumber = layerReactNumber;
        }
        public void OnProtectionFall(object sender, ProtectionFallEventArgs container)
        { }

        public int LayerReactNumber { get; set; }

        public string Message => $"Date: {123}\nSystem Name: {456}\nFallen layer number: {789}";

    }
}
