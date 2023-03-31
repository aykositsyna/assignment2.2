using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Skyda skyda = new Skyda();
            ProtectionSystem protectionSystem = new ProtectionSystem();
            skyda.ProtectionSystem = protectionSystem;
            protectionSystem.Title = "System";
            protectionSystem.ProtectionLayerNumber = 3;
            protectionSystem.Date = DateTime.Now;
            EndLayerNotifier end = new EndLayerNotifier();
            BasicLayerNotifier basic = new BasicLayerNotifier();
            basic.Subscribe(skyda);
            end.Subscribe(skyda);
            
            for (int i = 0;  i < 50; i++) 
            {
                skyda.Attack();
                skyda.NotifyProtectionFall();
                if (!string.IsNullOrEmpty(basic.Message))
                {
                    Console.WriteLine(basic.Message);
                    basic.Message = null;
                }
                if (!string.IsNullOrEmpty(end.Message))
                {
                    Console.WriteLine(end.Message);
                    break;
                }

            }
        }
    }
}
