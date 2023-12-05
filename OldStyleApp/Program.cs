using System.Drawing;
using System.Globalization;

namespace OldStyleApp
{

    public class Program
    {

        static void Main(string[] args)
        {
            // 1.Ints
            // deklarirana varijaba po ime//declaring
            // int num1,num2,num3;//moze i poveke na edna linija koja posle toa se koristi dolu za davanje vrednost
            //// ova e davanje na nejzina vrednost//assigning
            // num1 = 5;
            //num2 = 10;  
            //// deklaracija i davanje vrednost na edno mesto
            // num2 = 20;
            //int sum = num1 + num2;

            //Console.WriteLine("num1: " + num1 + " num2: " + num2 + " is " + sum  );    
            //Console.ReadLine();

            //double
            //double d1 = 3.14;
            //double d2 = 5.1;
            //double dDiv = d1 / d2;
            //Console.WriteLine(dDiv);

            ////float no na kraj mora da primi "f" inace ne raboti
            //float f1 = 3.1415f;
            //float f2 = 5.1f;
            //float dFl = f1 / f2;    
            //Console.WriteLine(dFl);

            ////longs
            ////integer ne prifaka tolku golem broj samo logn
            ////samoto ime kazvit
            //long numberLong = 7647546547647;
            //Console.WriteLine(numberLong);


            //double dIDiv = d1 / num1;
            ////int DIdiv = d1 / num1; vaka ne e mozno ima greska zoso cel broj e smesteno delenjeto na double so int
            //Console.WriteLine(dIDiv);   


            // 2.STRINGs
            //string myName = "Petar";// sme zele eden string
            //string message = "My name is " + myName;// sme go spojale ama ovoj pat vo varijabla od string

            //string capsMessage = message.ToUpper();//metod toUpper() gi pravi site vo golemi bukvi
            //string capsMessage2 = message.ToLower();// ovoj metod gi pravi vo mali bukvi 
            //Console.WriteLine(capsMessage2);  


            // 3. Value Type and Reference Type:
            // Value-
            // Store actual data directly,
            // Obicno se naoga na Stack,(ova znaci deka memoriskiot del avtomatksi se locija ili se pravi delokacija)
            // ima: int,float,long,double,char,bool,struct,enum
            // ima i: nulable verzii od tipot int?,double? ect.

            // Reference -
            //Toa e ,koga namesto direktno da se dodade vrednosta vo memorija,
            //prvo se zacuvuva adresata na varijablata,
            // a posle vnatre pravi druga adresa za nejzinata vrednost
            // kaj int imame direknto na stak davanje vrednost,
            // ama kaj string ne prvo se kreira adresa za imeto na dadenata
            //varijabla a posle toa se stava memorija za nejzinata vrednost


            // 4 Console methods

            //Console.Write();
            //Console.ReadLine();
            //Console.ReadKey();
            //Console.WriteLine();

            //  Console.WriteLine("Enter and press enter");
            //  string readInput = Console.ReadLine();
            //  Console.WriteLine("Enter a string and press enter");
            //int asciiValue = Console.Read();// ova provervit ACSII ili broj od dadena bukva iili del 
            //  Console.WriteLine("ASCII of value {0}: " + asciiValue);
            //  Console.ReadKey();  





            // 5.Imlicit and Explicit convenctions
            // Explicit e ova:

            //double myDouble = 13.99;
            //int myInt;
            //// cast double to int
            //myInt = (int)myDouble;  // ova vika vaka: go zemam myInt (prazen e pred se)
            // so (int) go pravam myDouble vo celosen broj ili ke go zaokruzi brojot koj e prv ako e
            // 13.33 ke dade 13 ili prviot broj (glavniot) a ne gi zema decimalite
            //Console.WriteLine(myInt);


            //   Implicitm e ova:

            /// mu davam vrednost direktno ama toa znaci da soodejstvuvaat 
            /// int i double ne se isti pa zatoa mora (int) ili pointer kade sto ke mu se kaze da se prepravi nestoto
            /// a vo ovoj slucaj na primer int i long se isti samo memoriskiot kapacitet za store na ogromni sumi im e razlicen
            /// long e pogolem pa zatoa mozam da smestam int , a istoto e i so float i double i dvete se od ist karakter-primaat decimali!!!
            //int num = 122121233;
            //long myLong = num;
            //Console.WriteLine(myLong);


            //float dr = 12.3333f;
            ////double drRes = dr;  
            ////Console.WriteLine(drRes);   


            //// Type convertion e ova:
            
            //string myString = myDouble.ToString(); 
            //// ovoj del go pravi brojot so "" ama ne dava vo praksa gi dava broevite ama gi prifaka kako string;
            //Console.WriteLine(myString);    
            //string myString2 = dr.ToString();
            //Console.WriteLine(myString2);

            //bool sunShining = false;
            //string myBool = sunShining.ToString();
            //Console.WriteLine(myBool);  
            // sto znaci i bool moze da se konvertira vo string


            //6. Parsing
            //string myString = "15";
            //int num1 = Int32.Parse(myString);

            //string mySecondString = "10";
            //int num2 = Int32.Parse(mySecondString);

            //string result = myString + mySecondString;
            //int result2 = num1 + num2;
            //Console.WriteLine(result2);
            // poso ova e string operatorot + ne go prifaka kako da sobira
            // tuku konkatetrira ili spojuva stringovi

            //string stringForFloat = "0.85"; // datatype should be float
            //float parsFloat = float.Parse(stringForFloat);  
            //string stringForInt = "12345"; // datatype should be int
            //int parsForInt = Int32.Parse(stringForInt); 


            //7.Concatenation of strings
            //    int age = 29;
            //    string name = "Petar";
            //    string color = "Black";
            //            Console.WriteLine("My name is {0}, and i have {1} years,and fav color is {2}",name,age,color);
            //    Console.WriteLine($"My name is {name}. and i have {age} years and fav color is {color}");
            //    //ova raboti po indeksi znaci 0 e vo ovoj slucaj name ,a 1 e age toa vazi samo vo console.writeline()

            //    // postojat i Verbatim string tie bukvalno go tolkuvaat tekstot osobeno koga ima prazni mesta
            //    Console.WriteLine(@"lskdfjvlskfjv
            //                      lskdjvslkdjvskldjfv
            //                      slkjvslkdfjvslkdfjvsvklsjdlkvjsdlkvjsdv
            //                      sldkjvslkdjvlskdjvlksdjvlskdjv
            //                      skldvjslkdjvdslk");//znaci sum ostaval mesto i toa taka go dava kako vo Javascript
            //    //so bese `` ovie tamu davaat nov red , a ovde @ toa go pravi istoto.
            //    // OVie se koristat Verbatim osobeno koga imame rabota so pat na nekoj fajl koga ke se citaat ili nesto takvo.

            //    // se koristti i \n za ostavanje na prazno mesto
            //    Console.WriteLine("ova e \n dobro ama \n to e");
            //}



            //8. Nekoi String Metodi
            //-Substring();
            //  string name = "Petar";
            //string substring =  name.Substring(0,name.Length-2);// ovde vikame sledno:
            //  // pocni od 0 indeks poso string po pravilo e niza , a ako e niza e Zero Indexered,
            //  // pa posle odime od 0 pa do predposledniot ili toa e name.legnth-2 ili poslednite 2 bukvi od dolzinata,
            //  // na zborot

            //  Console.WriteLine(substring);

            //Trim();
            //// trim e metod koj gi vraka od prazni linii recenici ili stringot 
            //// ova e od dvete strani
            //string text = "   Hello, World!   ";
            //string trimmedText = text.Trim();
            //Console.WriteLine(trimmedText);

            //// trimStart e od napred
            //string text2 = "   Hello, World!   ";
            //string trimmedStartText2 = text2.TrimStart();
            //Console.WriteLine(trimmedStartText2);

            //// trimEnd e od nazad
            //string text3 = "   Hello, World!   ";
            //string trimmedEndText3 = text3.TrimEnd();
            //Console.WriteLine(trimmedEndText3);


            //- IndexOf();
            //string text = "Hello, World, Petar!";
            //int indexOfComma = text.IndexOf("P");

            //Console.WriteLine(indexOfComma);// ova bara indeksi na poziciite na nekoja bukva

            //string a = "Petar";
            //string b = "Nikoloski";
            //string ress = string.Concat("",a, b,"");  //concat pravi concatentation direkten
            //// ama klucno e da mu se kaze string.Concat() za da moze da se zemat vars koi sakame da se spojat
            //Console.WriteLine(ress);    

            //string? str4 = null;
            //bool result4 = string.IsNullOrWhiteSpace(str4);
            //Console.WriteLine(result4);  // ke vratit false, zoso ovde imat polna varijabla a ako imame "" ili
            // prazno IsNullOrWhiteSpace() ke vratese true , poso provervit dali stringot e prazen ili null

            //string s1 = "Petar \" Nikoloski \" is my  name";
            //Console.WriteLine(s1);


            //string myName = "Petar Nikoloski";
            ////Console.WriteLine("Enter a Last Name pleace!");
            ////string myLastName = Console.ReadLine();
            ////string result = String.Format("Your name is {0} and last Name {1}", myName.ToUpper(), myLastName.ToUpper());    
            //string subs = myName.Substring(0, 5);
            //Console.WriteLine(subs);  


            //Console.WriteLine("Enter a string here:");
            //string ask1 = Console.ReadLine();
            //Console.WriteLine("Enter the character to search");
            //char character = Console.ReadLine()[0];

            //int solution = ask1.IndexOf(character);//index samo so int mozit zso vagat index;
            //Console.WriteLine("Index of your {0} letter is {1}",character,solution);


            //string controlText = "I control the text";

            //string numberControl = "15";
            //int num = Int32.Parse(numberControl);
            //Console.WriteLine(num); 

            // 9. Var Keyword
            //var number = 2;
            //number = 5;

            //Console.WriteLine(number);
            //  var num;- ako sakam bez vednost da e ne e mozno zoso taa ne znae za koj podatok ili type ke e dodelen
            // sto znaci bara vnesuvanje na vrednost od samiot start,a isto taka ne e mozno 
            //da se menuva vrednosta ednas dadena so VAR nema vrakanje ;

            // isto taka Var ne mozat i ne smeat da se NULL;
            //ovde davame klucen zbor "VAR" ili var
            // ova e int zoso var moze da primi 3 data types, (int,char,string,float...) zoso e smislena kako store za site varijanti

            //   -Constants:
            // Tie Ne se promenuvaat ,znaci ednas dadeni i tie se konstantni nemaat menuvanje,i traat dodeka zivee programata
            // const double pi = 3.14;
           
        }

    }
}