using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BollerwagenSharp
{
    class c_UCC
    {
        Thread GPIO_Check;

        c_GPIO GPIO;
        GUI GUI;

        
        public c_UCC()
        {
            GPIO = new c_GPIO();
            GUI = new GUI();
            
            GPIO_Check = new Thread(CheckSwitches);


        }

        ~c_UCC()
        { 
        }

        private void CheckSwitches()
        {
            if (GPIO.CheckInput(c_GPIO.IN.GPIO24))
            {
                GUI.SchalterAn();
            }
            else
            {
                GUI.SchalterAus();
            }
        
        }

        public void An()
        {
            GPIO.SwitchOut(c_GPIO.OUT.GPIO17, true);
        }
        public void Aus()
        {
            GPIO.SwitchOut(c_GPIO.OUT.GPIO17, false);
        }
    }
}
