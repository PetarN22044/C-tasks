using System.Collections;
using System.Globalization;

namespace Collection_s
{
    internal class Program
    {
     //public static List<int> EvenNumsByList()
     //   {
     //       List<int> evenNums = new List<int>();
     //       for (int i = 100; i <= 170; i++)
     //       {
     //           if (i % 2 == 0)
     //           {
     //               evenNums.Add(i);
     //           }
     //       }
     //       return evenNums;
     //   }




        static void Main(string[] args)
        {
            //Kolekcii
            ///Во контекстот на програмирањето, терминот "колекција" се однесува на структура,
            ///или објект кој чува група од објекти. Колекциите обезбедуваат начин да се чуваат, 
            ///организираат и манипулираат податоци на начин кој овозможува лесен пристап 
            ///и управување со нив. Во повеќето програмски јазици,
            ///колекциите обично се дизајнирани за работа со групи од објекти од ист или различен тип.
            /// Постојат 2 типа и тоа Генерички и Не-Генерички
            /// Генерички се -
            /// List<T>: Динамичка листа која може да содржи елементи од било кој тип T.

            // Dictionary<TKey, TValue>: Речник кој содржи клуч-вредност парови, каде што TKey и TValue се типови за клуч и вредност.

            // Queue<T>: Опашка која чека елементите да бидат извлечени во редоследот во кој биле додадени.

            // Stack<T>: Стек кој овозможува пристап и измена на последниот додаден елемент.

            //HashSet<T>: Множество кое чува уникатни елементи.


            // а не Генерички се
            // -ArrayList: Динамичка листа која може да содржи објекти од било кој тип, бидејќи се чуваат како object.

            // Hashtable: Речник со клуч - вредност парови, каде што клучот и вредноста се од тип object.

            // Queue: Опашка која може да чува објекти од било кој тип.
            // Главната разлика меѓу генеричките и негенеричките колекции во C# ,
            // е во начинот на работа со типови.

            //Генерички колекции:

            // Генеричките колекции користат генерички типови,
            // што значи дека можат да работат со различни типови на податоци.
            //Ова овозможува безбедно и ефикасно користење на типови,
            //бидејќи типот на податоци се специфицира при креирање на колекцијата
            //(пр.List<int>, Dictionary<string, object>).
            //Генеричките колекции обезбедуваат контрола и сигурност при работа со податоци,
            //и овозможуваат перформанси поради отсутноста на кастови и бесплатна проверка на типови.

            //Негенерички колекции:
            //
            //Негенеричките колекции користат објекти(object) како типови за податоци.
            //Ова значи дека колекцијата може да чува објекти од било кој тип,
            //но се губи контролата врз типовите при извршување.
            //При користење на негенерички колекции, често се потребни кастови и проверки на типови,
            //што може да доведе до безбедносни и перформансни проблеми.
            //

            //declaring Array List
            //ArrayList myArrayList2 = new ArrayList(100);
            //myArrayList2.Add(1);
            //myArrayList2.Add(5);
            //myArrayList2.Add(6);

            //double sum = 0;
            //foreach (object i in myArrayList2)
            //{
            //    if(i is int)
            //    {
            //        sum += Convert.ToDouble(i);
            //    }
            //    else if(i is double)
            //    {
            //        sum += (double)i;
            //    }else if(i is string) {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine(sum);

            // za ArrayList morame da napravime prverka na site value tajp nase e da gi proverime a kaj List nemame vakva rabota





            //ArrayList myArrayList = new ArrayList();

            //myArrayList.Add(25);
            //myArrayList.Add("Hello");
            //myArrayList.Add(13.37);
            //foreach (var i in myArrayList)
            //{
            //   if (i is int)
            //    {
            //        Console.WriteLine("Integer is {0}",i);
            //    }else if (i is double)
            //    {
            //        Console.WriteLine("Double is {0}", i);
            //    }else if(i is string)
            //    {
            //        Console.WriteLine("String is {0}",i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("No type here");
            //    }
            //}


            //List<int> ints = EvenNumsByList();
            //foreach (int i in ints)
            //{
            //    Console.WriteLine(i);
            //}


            //HashTbales now!

            //Hashtable studentTable = new Hashtable();

            //Student student1 = new Student(1, "Marija", 98);
            //Student student2 = new Student(2, "Jason", 76);
            //Student student3 = new Student(3, "Clara", 43);
            //Student student4 = new Student(4, "Steve", 55);

            ////sega sakam da dodadam vo hasTable ovie studenti ama racno
            //studentTable.Add(student1.Id, student1);// gi zemam vo has table i so id i poso has barat key objekt i posle value? objekt
            //studentTable.Add(student2.Id, student2);//zatoa odime po id zoso taka ke se znajt na koj objekt ili student idet nestovo
            //studentTable.Add(student3.Id, student3);// pa taka imame id i posle celiot objekt znacit idto i ostatokot od objektot
            //studentTable.Add(student4.Id, student4);

            //Student storedStudent1 = (Student)studentTable[student1.Id];// no morame posle poso e hastable da go smestime vo student
            //                                                            // hastable e pretvoren vo objektot student i posle to so () direknto mu dodavame baranje na tabelata po ID
            //                                                            //   Console.WriteLine("Student {0}, name {1},GPA:{2}",storedStudent1.Id,storedStudent1.Name,storedStudent1.GPA);

            // poso hasTable imat key value najsoodvetno za printanje na celata tabela koja sme dodavale so foreach e da 
            // pocnime so DictionaryEntry
            //foreach(DictionaryEntry entry in studentTable)
            //{
            //    Student temp = (Student)entry.Value;
            //    Console.WriteLine("Id  {0}",temp.Id);
            //    Console.WriteLine("Name  {0}",temp.Name);
            //    Console.WriteLine("GPA  {0}", temp.GPA);
            //    Console.WriteLine("_________________");
            //    // vo ovoj slucaj 1-4 po id ke ni gi dajt od prviot nadolu do posledniot nagore
            //}

            //foreach (Student value in studentTable.Values)
            //{
            //    Console.WriteLine("Name  {0}", value.Name);
            //    Console.WriteLine("GPA  {0}", value.GPA);
            //    Console.WriteLine("_________________");
            //}

            // Hashtable studentTable = new Hashtable();


            //   Student[]  students = new Student[6];
            //   students[0] = new Student(1, "Petar", 55);
            //   students[1] = new Student(2, "Toni", 45);
            //   students[2] = new Student(3, "Dimitar", 37);
            //   students[3] = new Student(4, "Gjoko", 44);
            //   students[4] = new Student(5, "Gorde", 77);
            //   students[5] = new Student(5, "Nikola", 89);



            //foreach(Student s in students)
            //   {
            //       if (!studentTable.ContainsKey(s.Id))
            //       {
            //              studentTable.Add(s.Id, s);
            //           Console.WriteLine("Students with ID was added {0} and he is {1}",s.Id,s.Name);
            //       }
            //       else
            //       {
            //           Console.WriteLine("Student with Id {0} - {1} already exist",s.Id,s.Name);
            //       }
            //   }             

            //Dictionary<int,string> myDictionary = new Dictionary<int, string>()
            //{
            //    {1,"Petar" },
            //    {2,"Toni" },
            //    {3,"Dimitar" }
            //};


            //Employee[] employees =
            //{
            //    new Employee("CEO","Gwyn",95,200),
            //    new Employee("Menager","Joe",35,25),
            //    new Employee("HR","Lora",32,21),
            //    new Employee("Secretary","Petra",28,18),
            //    new Employee("Lead Developer","Astor",55,35),
            //    new Employee("Itern","Ernest",22,8),
            //};

            //Dictionary<string,Employee> employeesDirectory = new Dictionary<string,Employee>(); 


            //foreach (Employee emp in employees)
            //{
            //    employeesDirectory.Add(emp.Role,emp);
            //}


            //string keyToUpdate = "HR";
            //if (employeesDirectory.ContainsKey(keyToUpdate))
            //{
            //    employeesDirectory[keyToUpdate] = new Employee("HR", "Petar", 29, 34);//vaka se dodavat ili update se prajt
            //    Console.WriteLine("Key {0} was updated",keyToUpdate);

            //}
            //Employee emp11 = employeesDirectory[keyToUpdate];
            //Console.WriteLine(emp11.Role);
            //Console.WriteLine(emp11.Name);
            //Console.WriteLine(emp11.Age);

            //string key = "CEO";
            //Employee empl = employeesDirectory[key];

            //if (employeesDirectory.ContainsKey(key))
            //{
            //    Console.WriteLine("Employee Name : {0}, Role {1}, Salary{2}", empl.Name, empl.Role, empl.Salary);
            //}
            //else
            //{
            //    Console.WriteLine("Key {0} its not exist here",empl.Role);
            //}
            //for (int i = 0; i < employeesDirectory.Count; i++)
            //{
            //    KeyValuePair<string,Employee> valuePair = employeesDirectory.ElementAt(i);
            //    Console.WriteLine("Key at {0}",valuePair.Key);
            //    Employee employee = valuePair.Value;
            //    Console.WriteLine("Name {0}",employee.Name);
            //    Console.WriteLine("Role {0}",employee.Role);
            //    Console.WriteLine("Age {0}",employee.Age);
            //    Console.WriteLine("_________________");

            //}

            // naprajv nova klasa numbers i so id i name na brojot
            //posle to zedov so Dictonary int i string pa naprajv proverka dali go imat nestoto
            //values[id] ili od dic dali vnatre vo value poso to e dictonary go sodrzit id pod broj 2 
          //  Numbers[] numbers =
          //    {
          //      new Numbers(1,"one"),
          //      new Numbers(2,"two"),   
          //      new Numbers (3,"three"),

          //  };
          //  Dictionary<int,string> values = new Dictionary<int,string>();

          //foreach (Numbers nums in numbers)
          //  {
          //      values.Add(nums.Id,nums.Name);
          //  }// vo ovoj del sum moral nizata na numbers da ja dodam vo Dictonary
          // pa ako gi imam elementite vnatree mozam i da provervam dali nestata postojat

          //  int id = 2;
          //  if (values.ContainsKey(id))
          //  {
          //      Console.WriteLine(values[id]);
          //  }
          //  else
          //  {
          //      Console.WriteLine("Its not exist");
          //  }






        }
    }
}