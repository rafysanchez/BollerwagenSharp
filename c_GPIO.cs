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
        private enum IN : byte
        {
            GPIO24 = 24
        };
        private enum OUT : byte
        {
            GPIO17 = 17
        };

        //GPIO IN
        private GPIOMem in_gpio24;

        //GPIO OUT
        private GPIOMem out_gpio17;

        public c_GPIO()
        {
            InitializeGPIO();
        }

        ~c_GPIO() 
        {
            //GPIO freigeben
            in_gpio24.Dispose();

            out_gpio17.Dispose();
        }


        public void InitializeGPIO()
        {
            //IN
            in_gpio24 = new GPIOMem(GPIOPins.V2_GPIO_24, GPIODirection.In, false);

            //Out
            out_gpio17 = new GPIOMem(GPIOPins.V2_GPIO_17, GPIODirection.Out, false);
         }

        //Testen ob Schalter geschlossen ist
        public bool CheckInput(IN GPIO_Pin)
        {
            GPIOMem Input;
            switch (GPIO_Pin)
            {
                case IN.GPIO24: Input = in_gpio24;
                    break;
                default:
                    return false;
            }
            if (Input.Read() == PinState.High)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        //Outputs schalten
        public bool SwitchOutout(OUT GPIO_Pin, PinState State)
        {
            GPIOMem Output;
            switch (GPIO_Pin)
            {
                case OUT.GPIO17: Output = out_gpio17;
                    break;
                default:
                    return false;
            }
            Output.Write(State);
            return true;
        }
    }
    
}
