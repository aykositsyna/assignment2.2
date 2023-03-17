using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._2
{
    internal interface IReactProtectionFall
    {
        int LayerReactorNumber { get; }
        string Message { get; }

        void OnProtectionFall(object, ProtectionFallEventArgs)
        { }
        void Subscribe(Skyda)
        { }
    }
}
