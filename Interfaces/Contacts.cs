using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Contacts :Contact
    {
        public List<Contact> ContactsList { get; set; }

        public Contacts(List<Contact> contacts)
        {
            ContactsList = contacts;
        }
        public void GetName ()
        {
              foreach (Contact c in ContactsList)
            {
                Console.WriteLine($"{c.Name}");
            }

        }
        public void GetNumber () 
        {
           foreach(Contact c in ContactsList)
            {
                Console.WriteLine($"{c.Number} is the number");
            }
        }
       
  

      
    }


}
