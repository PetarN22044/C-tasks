using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace MethodsFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Methods
            ///Metodi se block of code vo koj vnatre sodrzi statements ili operacii ili logika nekoja,
            ///<Access Specifier><ReturnType><Method Name>(params){
            ///    -Method Body
            ///    }= ova e negovata sintaksa,imame acces specifier
            ///    -ova ja definira negovata vidlivost,
            ///    posle return type = toa e koja vrednost ke ja vraka-
            ///    toa moze da e prikaz, ineger ili string ili neso slicno so ke vrakame i mora da se naglasi
            ///    posle imame parametri so koi ke igrame vnatre vo bodito na nekoj metod
            ///    a vo metod bodi imame logika i manipulacija so parametrite no moze i bez niv

            // int Add(int num1,int num2)
            //{
            //    int result = num1 + num2;   
            //    return result;
            //}
            //Console.WriteLine(Add(5,4));

            // WriteComething();
            // vnatre ova ocekuva argument na dolu navedeniot parametar ''- myText
            // WriteSpecific("Petar NIkoloski");
            //moze i da se storira vo int -metodata pa da se istapma za da bide vidliva
            //int result =  Add(5, 4);
            //  Console.WriteLine(result);
            // vo ovoj del zema dve funkcii kako argiment
            //int bigResult =  Add(Add(5,4),Add(3,2)); 
            //  Console.WriteLine(bigResult);

            //int multiply = Multiply(Multiply(2,3),Multiply(5,4));
            //Console.WriteLine(multiply);    
            //string a = "Petar";
            //string b = "Toni";
            //string c = "Dimitar";
            //GreetFriend(a, b, c);   
            //LowUpper("Petar Nikoloski");
            // LengthOfWord("Petar Nikoloski");
            //ResultOfInts();-ovde nemame parametri

            //Console.WriteLine("Enter a  number");
            //string userInput = Console.ReadLine();

            //try
            //{
            //    int userInputAsInt = Int32.Parse(userInput);
            //    int result = userInputAsInt / 0;
            //    Console.WriteLine(result);
            //    // ako sakame da delime so nula ne mozit!!!!

            //}
            //catch (DivideByZeroException) { 
            //Console.WriteLine("Cannot divide by zero");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Too logn for a32 bits to hold");
            //}
            //catch (OverflowException)
            //{
            //    //throw;
            //    Console.WriteLine("Enter numbers not strings");
            //}
            //catch (ArgumentNullException)
            //{
            //    Console.WriteLine("Null");
            //}
            //finally
            //{
            //    Console.WriteLine("Must go on");

            //}
            // unary operators
            //int num1 = 5;
            //int num2 = 0;
            //int num3;
            //num3 = -num1;
            //Console.WriteLine("Num3 is {0}", num3);
            //bool isSunny = true;
            //Console.WriteLine("Is it sunny? {0}",!isSunny);
            ////increment operators
            //num2++;
            //Console.WriteLine(num2);
            //Console.WriteLine(num2++);
            //Console.WriteLine(++num2);
            //int num = 5;
            //int num2 = 4;
            //num2++;
            ////bool isGreath = num < num2;
            ////Console.WriteLine("Num1 is < than Num2 {0}", isGreath);

            //bool isEqual  = num == num2;
            //Console.WriteLine("Num1 is == to Num2 {0}",isEqual);

            //bool isNotequal = num != num2;
            //Console.WriteLine("Num1 is != to Num2 {0}", isNotequal);

            //bool isCheck = false;
            //isCheck = isEqual || isNotequal;
            //Console.WriteLine(isCheck);

            // ovdeka imam bez if else proverka taka so zemame bool varijabla pa vnatre dodavame logika
            //Console.WriteLine("Num is :{0}", num);
            //Console.WriteLine("Num is :{0}", ++num);
            //Console.WriteLine("Num is :{0}", ++num);

            //Console.WriteLine("Num is :{0}", num2);
            //Console.WriteLine("Num is :{0}", num++);
            //Console.WriteLine("Num is :{0}", ++num);
            //int result = num + num2;
            //Console.WriteLine(result);




        }
        // acces mofifier(static) 
        public static void WriteComething()
        {
            Console.WriteLine("I am called method");
        }
        public static void WriteSpecific(string myText)
        {

            Console.WriteLine(myText);
        }
        public static int Add(int param1, int param2)
        {
            int result =  param1 + param2; 
            return result;

        }
        public static int Multiply(int n1 , int n2)
        {
            int result = n1 * n2;   
            return result;  
        }
        public static void GreetFriend(string a, string b, string c)
        {
            Console.WriteLine($"Hello {a} and {b} and ofcourse {c}");  
        }
        public static void LowUpper(string a)
        {
            string input = a.ToLower();
            string one = input.ToUpper();
            Console.WriteLine(one);
        }
        public static void LengthOfWord(string a)
        {
            int input = a.Length;
            Console.WriteLine(input);   
        }
        public static void ResultOfInts()
        {
            Console.WriteLine("enter nu1");
            int ask  = int.Parse(Console.ReadLine());  
            Console.WriteLine("enter num2");
            int ask2 = int.Parse(Console.ReadLine());
            int result = ask + ask2;
            Console.WriteLine(result);
            
        }
    }
}