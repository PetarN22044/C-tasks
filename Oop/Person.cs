using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    internal class Person
    {
        private string _name;
        private string _lastName;
        private string _email;
        private int _birthdayDay;
        public Person()
        {
            
        }
       
        public int BirthdayDay { set { _birthdayDay = value; } }
        public void BirthDay (int birthday)
        {
            _birthdayDay = birthday;
            if (birthday == 0)
            {
                throw new Exception("Must enter valid number");
            }
            else
            {
                Console.WriteLine("Your Birthday is {0}",birthday);
            }
        }
        public string getName()
        {
           return _name;
        }// vo ovoj del samo sme go zele imeto od tamu kade sto sme go setirale.
        // a to e dolu znaci sme go napravile deafult po pravilo, posle to sme dodale ime vo program a koga ke istampame getName 
        // go vadit imeto kade sto sme ja instancirale varijablata i sme dodale ime
      
        public string getLastName()
        {
            return _lastName;
        }
        public string getEmail()
        {
            return _email;
        }
        public void setName(string name)
        {
            _name = name;// ova e set {set;} ili ovaa funkcionalnost ja imat znaci ja zemame kako private
            // pa posle ja inicijalizirame so argumentot pa posle ko ke ja pvikame funkcijata ako ja isprintame imame podatok celosen
           if (name == "") {
                _name = "Deafult";
                Console.WriteLine(_name);
            }
            else
            {
                _name = name;
                Console.WriteLine(name);
            }
        }
        public void setLastName(string lastName)
        {
            _lastName = lastName;
            if (lastName != null)
            {
                Console.WriteLine(lastName);    
            }
        }
        public void setEmail(string email)
        {
            _email = email;
            if (email != null)
            {
                Console.WriteLine(email);
            }
        }
    }
}
