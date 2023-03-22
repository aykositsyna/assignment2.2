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

        public virtual bool ProtectionCheck(int CurrentPtotectionLayerNumber)
        {
            bool isUnbroken = CurrentPtotectionLayerNumber <= ProtectionLayerNumber;
            Date.AddDays(1);
            return isUnbroken;
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
