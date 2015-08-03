using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RaspberryPiDotNet;
using System.Windows.Forms;

namespace BollerwagenSharp
{
    class c_GPIO
    {
        private GPIOMem gpio17;
        private GPIOMem gpio24;
        int i = 0;

        public c_GPIO()
        {


        }

        ~c_GPIO() 
        {
        }


        public string schalter()
        {
            if (gpio24 == null)
            {
                gpio24 = new GPIOMem(GPIOPins.V2_GPIO_24);
                gpio24.PinDirection = GPIODirection.In;
            }
            return gpio24.Read().ToString();
         }

        public void an()
        {
            if (gpio17 == null)
            {
                gpio17 = new GPIOMem(GPIOPins.V2_GPIO_17);
            }
            gpio17.Write(PinState.High);

        }

        public void aus()
        {
            if (gpio17 == null)
            {
                gpio17 = new GPIOMem(GPIOPins.V2_GPIO_17);
            }
            gpio17.Write(PinState.Low);
        }

        public void test()
        {
            GPIOMem test;

            switch (i)
            {
                case 0: test = new GPIOMem(GPIOPins.GPIO_17);
                    test.Write(PinState.High);
                    test.Dispose();
                    break;
                case 2: test = new GPIOMem(GPIOPins.V2_GPIO_17);
                    test.Write(PinState.High);
                    test.Dispose();
                    break;
               

            }
            
                
        
        }
    }
    
}
