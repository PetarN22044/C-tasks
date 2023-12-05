using Polimorphism.Car;
using Polimorphism.Shape;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var cars = new List<Car>
            //{
            //    new Audi(200,"blue","A4"),
            //   new BMW(250,"red","M4"),
            //};

            //foreach (var car in cars)
            //{
            //    car.Repair();
            //}

            //M3 myM3 = new M3(300, "black", "M3");
            //myM3.Repair();

            //Car bmwZ3 = new BMW(200, "black", "Z3");
            //bmwZ3.SetCarIDInfo(12, "Petar Nikoloski");
            //bmwZ3.GetCarIDInfo();

            //Shape[] shapes = { new Sphere(4), new Cube(3) };
            //foreach (Shape shape in shapes)
            //{
            //    shape.GetInfo();
            //    Console.WriteLine("The {0}, has a {1} of worth",shape.Name,shape.Volume());
            //    Cube iceCube = shape as Cube;
            //    if (iceCube == null)
            //    {
            //        Console.WriteLine("The shape is not Cube");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The Shape is Cube");
            //    }
            //    if(shape is Cube)
            //    {
            //        Console.WriteLine("The shape its also a Cube");
            //    }

            //    object cube1 = new Cube(5);
            //    Cube cube2 = (Cube)cube1;
            //    Console.WriteLine("The {0} has volume of {1}",cube2.Name,cube2.Volume());

            //}

            //string text = System.IO.File.ReadAllText(@"C:\Users\User\Petar22222 Dropbox\Ph Dht\PC\Desktop\textFile");
            //Console.WriteLine(text);


            //string filePath = @"C:\Users\User\Petar22222 Dropbox\Ph Dht\PC\Desktop\C# courseNow\HelloWorldNow\ConsoleApp1\text\textFile1.txt";

            //string outputPath = @"C:\\Users\\User\\Petar22222 Dropbox\\Ph Dht\\PC\\Desktop\\C# courseNow\\HelloWorldNow\\ConsoleApp1\\text\textFile2.txt";

            //using(StreamReader sr = new StreamReader(filePath))
            //{
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        if (line.Contains("split"))
            //        {
            //            string[] elements = line.Split(' ');
            //             using(StreamWriter sw = new StreamWriter(outputPath,true))
            //            {
            //                sw.WriteLine(elements[4]+ " ");
            //            }
            //        }
            //    }
            //}


           







            //string[] array = {"First","Second","Third" };
            //using (StreamWriter writer = new StreamWriter(filePath,true))
            //{
            //   foreach (string item in array)
            //    {
            //        if (item.Contains("Third"))
            //        {
            //            writer.Write("Third");
            //        }
            //    }
            //}







            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //string nameFull = "The name of user its";

            //Console.WriteLine("Enter your age");
            //int age = int.Parse(Console.ReadLine());
            //string ageOfUser = "Age of user ";


            //File.AppendAllText(filePath, nameFull + name + Environment.NewLine);
            //File.AppendAllText(filePath, ageOfUser + age + Environment.NewLine);









            //Console.WriteLine("The text path if its array its");
            ////string[] lines = System.IO.File.ReadAllLines(filePath);
            ////foreach (string line in lines)
            ////{
            ////    Console.WriteLine("\t" + line);
            ////}

            //string[] lines = { "first line", "second line", " third line" };
            //File.WriteAllLines(filePath, lines);


        }
    }
}// vo konceptot na polimorfizam na vazno e povtoruvanjeto na metodite, no isto taka i nasledstvoto na klasite
/// ne e mozno da se napravi Polimorfisticko nasleduvanje ako predhodno ne se stavi virtual na glavniot metod koj e smislen za
/// povtoruvanje, ako posle na toj sto ke sakame da e povtoren ne mu dodademe vrednost na ovverrite... 
/// mnogu bitno e i klucniot zbor sealed; toj moze da zapecati da ne no i glavni klasi ,odnosno klasi ili metodi koi se virtual,
/// moze samo i samo na onie koi nasleduvaat.VO ovoj primer imame glavna klasa Car, posle Audi i Bmw mozam na ovie nasledeni klasi da
/// gi zapecatuvam metodite i toa pred ovverrite zborot da go dodadam sealed ili kako i da se pisit!;.