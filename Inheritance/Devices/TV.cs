using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Devices
{
    public class TV : ElectricalDevice
    {

        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }


        public void WatchTv()
        {
            if (IsOn)
            {
                Console.WriteLine("Watch TV");
            }
            else
            {
                Console.WriteLine("TV is switched off,switch it on first");
            }
        }
    }
}
