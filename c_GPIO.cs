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
        public enum IN : byte
        {
            GPIO24 = 24
        };
        public enum OUT : byte
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
            if (new GPIOMem(GPIOPins.V2_GPIO_24).IsDisposed)
            {
                in_gpio24 = new GPIOMem(GPIOPins.V2_GPIO_24, GPIODirection.In);
            }
            else 
            {

            }
            

            //Out#
            out_gpio17 = new GPIOMem(GPIOPins.V2_GPIO_17);
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
        public bool SwitchOut(OUT GPIO_Pin, bool Closed)
        {
            GPIOMem Output;
            switch (GPIO_Pin)
            {
                case OUT.GPIO17: Output = out_gpio17;
                    break;
                default:
                    return false;
            }
            Output.Write(Closed);
            return true;
        }
    }
}
