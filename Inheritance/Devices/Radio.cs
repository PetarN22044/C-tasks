using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Devices
{
    //CHILD CLASS
    public class Radio : ElectricalDevice
    {


        public Radio(bool isOn, string brand) : base(isOn, brand)
        {
            //koga prajme base znacit deka nemat potreba 
            //kostruktorot da imat parametri ,zoso gi imame vo glavnata klasa
        }


        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening the radio");
            }
            else
            {
                Console.WriteLine("Radio is switched off,switch it on first");
            }
        }
    }
}
