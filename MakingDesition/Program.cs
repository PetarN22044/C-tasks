using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MakingDesition
{
    internal class Program
    {
        //public static void ScorePlayer (int score, int highScore, string playerName)
        //{
            
        //   if(score < highScore)
        //    {
        //        Console.WriteLine("You are not so close,try again");
        //    }else if(score > highScore)
        //    {
        //         highScore = score;
        //        Console.WriteLine("Your score is {0} and you are {1}", score, playerName);
        //        Console.WriteLine(highScore + "This is the highscore now");
        //    }
        //}
        static void Main(string[] args)
        {
            //int highScore = 100;
            //Console.WriteLine("Enter a player name");
            //string playerName = Console.ReadLine();
            //Console.WriteLine("Enter a player score");
            //int score = int.Parse(Console.ReadLine());

            //ScorePlayer(score,highScore,playerName);
            //zadaca bese ova!

            //Skratena sintaksa na if else statements!
            // uslov ? prva_ekspresija : vtora_ekspresija
            //int temperature = -5;
            //string stateOfMatter;
            //stateOfMatter = temperature  < 0 ? "solid" : "liquid";
            // se zema varijablata vo koja sakam nesto da zapise i sea - ja zemam temperaturata pa ja sporeduvam ili davam uslov,
            // posle toa imam ? kako sintaksa i pisuvam ako e pomalu od 0 togas e solid ako e poveke e likvid i to e zamena za if else sintaksata
            //if (temperature < 0)
            //    stateOfMatter = "Solid";
            //else
            //    stateOfMatter = "Liquid";

            //  Console.WriteLine("State of Matter is {0}",stateOfMatter);

            //Console.WriteLine("Enter your years");
            //int yearOfPerson = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter your name");
            //string nameOfPerson = Console.ReadLine();
            //string emptyName;

            //emptyName = yearOfPerson <= 15 ? "You cannot enter" : "you can enter";

            //Console.WriteLine("Your status is {0} and you are {1}", emptyName,nameOfPerson);

            //Console.WriteLine("Enter a temperature in your town");
            //string temperatureAsk = Console.ReadLine();
            //int temperature;
            //bool isNumTemp = int.TryParse(temperatureAsk, out temperature);

            //string check =  isNumTemp ? "Its not int" : "Its int";

            //Console.WriteLine("And you are correct");
            //string checkTemp = temperature < 0 ? "Its so cold under Zero" : "It more than Zero";
            //Console.WriteLine("The temerature of {0} is {1}",temperature,checkTemp);









            //Console.WriteLine("Enter a temperature at your home");
            //string temperature = Console.ReadLine();
            //int temp = int.Parse(temperature);
            //if (temp < 4)
            //{
            //    Console.WriteLine("Its so cold outside");
            //}
            //else if (temp == 4)
            //{
            //    Console.WriteLine("Still Cold and its {0}",temperature);
            //}
            //else 
            //{
            //    Console.WriteLine("It is cold with condition to be warm");
            //}
            // edina mana na ovoj del e so stalno povikuvame if,if sekako seto od ovie se zema za svoviden kod
            // i to zafakat memorija, a ako se promenit samo kako eden if so if else i else e kako edno

            //tryParse() metod se koristi za konvertiranje na string vo number/broj
            //"12" ova e string ama so parsiranje togas nie pravie pretvaranje na brojki
            // ako pisime tekst "aldjh" togas pars ne raboti zoso kompajlerot poznava samo nums;
            //string num = "12";
            //int passedValue;
            //bool passed = int.TryParse(num,out passedValue);
            //Console.WriteLine(passed);//sme napravile provekra da tocno sme parsirale deka e int,vraka true.
            //// ova sluzit za proveka dali brojkata ili stringot e napraven vo int;
            //int parsingValue = int.Parse(num);//ova sluzit za da prikazime koj broj nie go parsirame so obicen parse,
            //// i posle go printame num poso toj e korenot;

            //Console.WriteLine("and his value its of {0}",num);
            //Console.WriteLine(parsingValue);
            //if (passed)
            //{
            //    Console.WriteLine("Number {0} is parsed",num);
            //}
            //else
            //{
            //    Console.WriteLine("Its not parsed");
            //}// ovde pravime dopolnitelna proverka so if else
            //float a = 3.12f;
            ////double b = (int)a;
            //double b = a;
            //Console.WriteLine(b);// ova e indirektno i direktno parsiranje ili prefrluvanej na vrednosta,a imame i type 
            //string temperature = Console.ReadLine();// sme zele string za ask nesto
            //int numTemp;// sme locirale prazna var bez vrednost
            //bool isTrueTemp = int.TryParse(temperature, out numTemp);
            //Console.WriteLine(isTrueTemp);// ovde e true ako e brojka
            //// sme zele bool  so cel da se proveri za,
            //// nestoto dali e parsirano
            //if (!isTrueTemp)// ako poso e true poso sme ja parsirale imame sledno:
            //    // ako e razlicno ili ako se vnese tekst ke izleze deka ima greska
            //{
            //    numTemp = 0;// ovde mora da i dademe vrednost na var zoso ako e prazna ke imame problem dolu
            //    Console.WriteLine("Value entered was not a number");
            //}

            //if (numTemp > 5)// potocno ovde keimame problem poso davame vrednost 5 a sekako toa mora da se sporeduva
            //{
            //    Console.WriteLine("It's still cold");
            //}
            //else if (numTemp < 5)
            //{
            //    Console.WriteLine("It's so cold");
            //}

            //int num = 5;
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}

            //bool isAdmin = false;
            //bool isRegistered = true;
            //string userName = "";
            //Console.WriteLine("ENter your User Name");
            //userName = Console.ReadLine();

            //if(isRegistered)
            //{
            //    Console.WriteLine("Hi there registered user");
            //    if(userName != "")
            //    {
            //        Console.WriteLine("Hi there" + userName);
            //        if (userName.Equals("Admin"))
            //        {
            //            Console.WriteLine("Hi there Admin");    
            //        }
            //    }
            //}// ova e eden nacin na nasted-if statement ama ima i drug
            //if (isRegistered && userName !="" && userName.Equals("Admin")){
            //    Console.WriteLine("Hi there registered user");
            //    Console.WriteLine("Hi there and welcome", userName);
            //    Console.WriteLine("Hi there Admin");
            //}
            //if (isAdmin || isRegistered)
            //{
            //    Console.WriteLine("You are logged now");
            //}
            //else
            //{
            //    Console.WriteLine("Not logged");
            //}

            //Console.WriteLine("Enter a number");
            //int input = int.Parse(Console.ReadLine());
            //if (input %3 == 0)
            //{
            //Console.WriteLine("Divide by 3");
            //}else if (input % 7 ==0)
            //{
            //    Console.WriteLine("Divide by 7");
            //} else if(input % 2 != 0)
            //{
            //    Console.WriteLine("Odd");
            //}
            //else
            //{
            //    Console.WriteLine("Even");
            //}
            //Console.WriteLine("Enter your UserName");
            //string inputUserName = Console.ReadLine();
            //bool isRegistered = true;
            //bool isLogged;  

            //if(isRegistered)
            //{ 
            //    Console.WriteLine("You are registered");
            //}
            //Console.WriteLine("Enter for Log now");
            //string inputLogged = Console.ReadLine();    
            //if (inputUserName.Equals(inputLogged) )
            //{
            //    isLogged = true;
            //    Console.WriteLine("You are logged");
            //}
            //else
            //{
            //    isLogged = false;
            //    Console.WriteLine("Your user Name is Not match");
            //}

            //Console.WriteLine("Enter years for validing the Club's enter's");
            //int age = int.Parse(Console.ReadLine());
            //if(age >=1 && age <= 15) {
            //    Console.WriteLine("You dont have permitions");
            //}
            //else
            //{
            //    Console.WriteLine("Not have permiton for Clubs entry ");
            //}
  // koga pisam vo konzola ako imam readline "" toa e isto kako da sum vnel i bukvi
      



        
        
        
        
        
        
        }
    }
}
