using Interfaces.Animal;
using Interfaces.Task;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ticket t1 = new Ticket(10);
            //Ticket t2 = new Ticket(10);
            //Console.WriteLine(t2.Equals(t1));


            //Weapon weapon = new Weapon("Petar","Nikoloski");
            //weapon.Shoot("AKA47");

            //Gun gun = new Gun("Er","NineM","Toni","Crvenkoski");
            //gun.Shoot("bang bang");


            //Lekcija : IEnumerable za T i za non-generic
            //Primer 1 :
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            //IEnumerable<int> enumerableNumbers = numbers;
            //// ovde se prevzela sodrzinata na nekoja lista vo IEnumerable<int>/...
            //foreach (int number in enumerableNumbers)
            //{
            //    Console.WriteLine(number);
            ////}

            //DogSelter shelter = new DogSelter();
            //foreach(var dog in shelter.dogs)
            //{

            //    if(!dog.IsNaughtyDog)
            //    {
            //        dog.GiveTreat(2);
            //    }
            //    else
            //    {
            //        dog.GiveTreat(1);
            //    }//sme upotrebile IEnumerable a to ni ovozmozilo da dojdime do sive so foreach a inace trebase racno da go vikame
            //metodov GiveThreat i sea poso kaj dog bool imame za dali e mirno ili ne i ako e mirno 2 ako ne e 1 
            // Vo ovoj slucaj koristime IEnumerable non-generic zosto,
            // pa nemame <T> prosto imame primitive types racno definirano
            //  Console.WriteLine(dog.Name + "  naughty is {0}",dog.IsNaughtyDog); // ova e racno resenie no ni treba enumerable interfejsov 


            //Console.WriteLine("The point of IEnumerable number");
            //int num = 3;
            //IEnumerable<int> ints = Getting.GetNumber(num);

            //foreach (int i in ints)
            //{
            //    Console.WriteLine(i + " ");
            //}


            //List<int> ints = new List<int>() { 1,2,3};
            //int[] numbers = { 4, 5, 6 };
            //Getting.SumCollection(ints);
            //Getting.SumCollection(numbers);
            List<Contact> ints = new List<Contact>()
            {
                new Contact("Andre", "435797087"),
                new Contact("Lisa", "435677087"),
                new Contact("Dine", "3457697087"),
                new Contact("Sofi", "4367697087")
            };
            Contacts contacts = new Contacts(ints);

            contacts.GetName();
            contacts.GetNumber();






            }




        }
    }
