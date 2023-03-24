﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2._2
{
    public class ProtectionSystem
    {
        public string Title;
        public DateTime Date;
        public int ProtectionLayerNumber;
        public int FalledProtectionLayerNumber;
        int SavedLayerNumber;

        public virtual bool ProtectionCheck()
        {
            if (SavedLayerNumber < FalledProtectionLayerNumber) 
            {
                SavedLayerNumber++;
                return true;
            }
            else { return false; }

            Date.AddDays(1);
            
        }

        public virtual void GetAttack()
        { 
            Random random = new Random();
            int rand = random.Next(0, 5);
            if (rand >= 3)
            {
                ProtectionLayerNumber--;
                FalledProtectionLayerNumber++;
                
            }
        }
    }
}
