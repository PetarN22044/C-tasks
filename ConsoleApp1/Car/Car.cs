using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism.Car
{
    public class Car
    {
        public int HP { get; set; }

        public string Color { get; set; }

        //relationship
        protected CarIdInfo carIDInfo = new CarIdInfo();    

        public void SetCarIDInfo(int idNum,string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0}, and the owner is {1}",carIDInfo.IDNum,carIDInfo.Owner);
        }


        public Car()
        {           
        }
        public Car(int hp,string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"HP: {HP} and the Color is : {Color}");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was reapired");
        }
    }
}
