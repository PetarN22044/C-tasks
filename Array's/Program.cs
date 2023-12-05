using System.ComponentModel;
using System.Globalization;

namespace Array_s
{
    internal class Program
    {
        //public static void EnterXorO(int player,int input)
        //{
        //    char playerSign = ' ';
        //    if (player == 1)
        //        playerSign = 'X';
        //    else if (player == 2)
        //        playerSign = 'O';

        //    switch (input)
        //    {
        //        case 1: playField[0, 0] = playerSign; break;
        //        case 2: playField[0, 1] = playerSign; break;
        //        case 3: playField[0, 2] = playerSign; break;
        //        case 4: playField[1, 0] = playerSign; break;
        //        case 5: playField[1, 1] = playerSign; break;
        //        case 6: playField[1, 2] = playerSign; break;
        //        case 7: playField[2, 0] = playerSign; break;
        //        case 8: playField[2, 1] = playerSign; break;
        //        case 9: playField[2, 2] = playerSign; break;

        //    }
        //}
        //static char[,] playField =
        //{
        //    { '1','2','3' },
        //    { '4','5','6' },
        //    { '7','8','9' },
        //};
        //public static void SetField()
        //{
        //    Console.Clear();
        //    Console.WriteLine("   |   |   ");
        //    Console.WriteLine(" {0} | {1} | {2} ", playField[0, 0], playField[0, 1], playField[0,2]);
        //    Console.WriteLine("___|___|___");
        //    Console.WriteLine("   |   |   ");
        //    Console.WriteLine(" {0} | {1} | {2} ", playField[1, 0], playField[1, 1], playField[1, 2]);
        //    Console.WriteLine("___|___|___");
        //    Console.WriteLine("   |   |   ");
        //    Console.WriteLine(" {0} | {1} | {2} ", playField[2, 0], playField[2, 1], playField[2, 2]);
        //    Console.WriteLine("   |   |   ");
        //}

        //public static void Average (int[] ints)
        //{
        //    int size = ints.Length;
        //    int sum = ints[0];
        //    for (int i = 0; i < size; i++)
        //    {
        //        sum += ints[i]; 
        //    }
        //    int result = sum / size;    
        //   Console.WriteLine (result);  
        //}
        //public static void IncreaserBy2 (int[] array)
        //{
        //    if (array != null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            Console.WriteLine(array[i]+2);
        //        }
        //    }          
        //}
        //public static void ParamsMethod(params string[] sentence)
        //{
        //    // ova params se koristit koga sakame premnogu ili ic parametri vo argumentot da stajme
        //    for (int i = 0; i < sentence.Length; i++)
        //    {
        //        Console.Write(sentence[i] +" ");
        //    }
        //}

        //public static void ParamsMethod2(params object[] stuff)
        //{
        //    foreach (object o in stuff)
        //    {
        //        Console.WriteLine(o + " ");
        //    }
        //}
        public static int MaxV2 ( params int[] numbers)
        {
            int max = int.MinValue;
            foreach ( int i in numbers )
            {
                if ( i > max )
                {
                    max = i;
                }
            }
            return max;
        }
        public static int MinV2(params int[] numbers) {

            int min = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;   
                }
              
            }
            return min;
        }
        static void Main(string[] args)
        {
            //Vo Js imame prifakanje na objekti i parametri od bilo kakov data type,
            //vo C# toa e nevozmozno no zato go imame params i to ne vadit primer imame dolu

            //   ParamsMethod("This", "is","a:","stupid","quote");

            // ParamsMethod2("Petar", 5.3, "Hello");
            //int num = 2;
            //float pi = 3.14f;
            //string book = "Alchemist";
            //char chare = 'E';
            //ParamsMethod2(num,pi, book, chare);
            // Console.WriteLine("{0}+{1}+{2}+{3}+{4}+{5}+{6}+{7} = {8}",1,2,3,4,5,6,7,9,1+2+3+4+5+6+7);
            //  int[] array = { 1, 2, 3, 4, 5 };
            // IncreaserBy2(array);
            //Average (array);

            int min = MinV2(2, 4, 6, 77, 1);
            int max = MaxV2(22, 44, 55);
            Console.WriteLine("The minimum is {0}",min);

            Console.WriteLine("The maximum is {0}", max);


            // prv nacin na inicijalizacija 
            //    int[] grades = new int[5];
            //    grades[0] = 20;
            //    grades[1] = 15;
            //    grades[2] = 12;
            //    grades[3] = 9;
            //    grades[4] = 7;
            //    Console.WriteLine("grades at intex 0 : {0}", grades[0]);

            //    Console.WriteLine("Enter to change the value of zero index now");
            //    string input = Console.ReadLine();
            //    // ovde mu se dodava vrednost ili se menuva vrednosta na grades[0];
            //    grades[0] = int.Parse(input);
            //    Console.WriteLine("grades at intex 0 : {0}", grades[0]);

            //    // vtor nacin na inicijalizacija
            //    int[] gradesOfMathStudentsA = { 20, 30, 40, 55,90 };
            //    Console.WriteLine("Length of array : {0}",gradesOfMathStudentsA.Length); 


            //    // tret nacin na inicijalizacija 
            //    int[] gradesOfMathStrudentsB = new int[] { 20, 30, 55, 66, 77, 65 };

            //int[] nums = new int[10];
            // za pocetok sme ja deklarirale nizata znacit kaj nums[i] = i a  i ima vrednost od 10 zoso tolku sme mu dale
            // a istot aka tolku e length od nizata
            //for (int i = 0; i < 10; i++)
            //{
            //    nums[i] = i +10;// ako ovde kaj i mu dodelam +10 ke ja zgolemi vrednosta na sekoja iretacija za 10 ili celosno I;
            //}
            // posle sme go iskoristile ova za pecatenje
            // ama ova e opasna praksa zoso ako j<11 na primer ke kazit out of boundaries ili nadvor od definiranata niza
            // zato mora ako imam ena primer 44444444 milioni vrednosti vo edna niza, kako ke znam na sekoe ako odam da proveruvam
            // ne e isplatlivo , pa zatoa ke napisam na vtoriov for loop nums.length namesto 10 kako so imavme predhodno;

            // for (int j = 0;j < nums.Length; j++) 
            // {
            //     Console.WriteLine("Element {0} = {1}", j, nums[j]);
            // }

            ////vtor nacin na printanje i najkoristen e foreach
            //int counter = 0; 
            //foreach(int k in nums)
            // {
            //     Console.WriteLine("index {0} - {1}",counter,k);
            //     counter++;
            // }

            //string[] friends = { "Petar", "Toni", "Dimitar", "Gordana", "Gjoko", "Trajan" };
            //int counter = 0;    
            //foreach (string friend in friends)
            //{
            //    Console.WriteLine("Hello my friend {0} and your index of array it's : {1}",friend,counter);
            //    counter++;  
            //}

            // for,foreach,do-while zoso se koristat 
            // int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //// so for mojme da prajme pojke manipulacii i polesno  nego so foreach vo ovoj slucaj sme gi preskoknale za 2 ili+=2 od broevite
            //// vo nizata koi se dadeni
            //for (int i = 1; i <= num.Length; i+=2) {
            //    Console.WriteLine(num[i]);// vaka gi dobivme parnite broevi...
            //}
            //string input;
            //do
            //{
            //    Console.WriteLine("Enter a valid number");
            //    input = Console.ReadLine();

            //} while (!int.TryParse(input, out _));

            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] % 2 != 0)
            //    {
            //        Console.WriteLine(num[i]);
            //    }
            //}

            // 2D and 3D arrays
            //string[,] matrix;//koga imam zapirka vo [,] znaci 2D array
            //int[,] array2D = new int[,]
            //{
            //     {1, 2, 3 },// row 0
            //     { 4, 5, 6 },//row 1
            //     { 6, 7, 8 }// row 2
            //};

            //Console.WriteLine("Central value of {0}", array2D[1,1]);// vo ovoj slucaj imame sledno
            //// 0 pozicija e {1,2,3} celosen objekt vo array2D ,posle 1 e {4,5,6} a indeks vo 1 kade imame 1 e vo ovoj
            //// slucaj 5

            //string[,,] array3D = new string[,,]
            //{
            //   {// row 0
            //        { "000","001" },//inside row 0
            //        {"002","003" }//inside row 1
            //    },
            //    {//row 1
            //        {"100","101" },//inside row 0
            //        {"110","111" }// inside row 1
            //    }
            //};
            //Console.WriteLine("Value is {0}", array3D[0,1,1]);
            //// postoi metoda Rank za da se vidi kolku dimenzii ima vo array
            //int dimension = array2D.Rank;
            //Console.WriteLine("The dimensions of array are {0}D",dimension);

            // int[,] matrix =
            // {
            //     { 1, 2, 3 }
            //    ,
            //     { 4, 5, 6 }
            //    ,
            //     { 7, 8, 9}                
            //};

            // dijagonala 3,5,7
            // for (int i = 0, j= 2 ; i < 3; i++,j--)
            //{
            //    Console.WriteLine(matrix[i,j] + " ");
            //}
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //   {
            //       for (int j = 0; j < matrix.GetLength(1); j++)
            //       {
            //           if ((j==2) && (i==0 || i==1 || i==2))
            //           {
            //               Console.WriteLine(matrix[i, j]);    
            //           }
            //       }
            //   }
            //int[] temperature = { 0, 13, 25, 31, 22, 32 };
            //Console.WriteLine(temperature.Length);
            //foreach (int i in matrix)
            //{
            //    Console.Write(i + " ");
            //}// ova e so foreach 
            //  for loop
            //Console.WriteLine("Printed by for loop");
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        if (i ==j)
            //        {
            //            Console.Write(matrix[i,j] + " ");
            //        }else
            //            Console.Write("");
            //    }
            //    Console.WriteLine(" ");
            //}// vaka ja printame dijagonalata od 1 , 5 , 9; pso i I i J se isti na isti pozicii

            //int player = 2; //player starts
            //int input = 0;
            //bool inputCorrect = true;
            //do 
            //{
            //    if (player == 2)
            //    { 
            //        player = 1;
            //        EnterXorO(player,input);
            //    }
            //    else if (player == 1)
            //    { 
            //        player = 2;   
            //        EnterXorO(player,input);
            //    }
            //    SetField();

            //#region
            //// proverka koj e pobednik
            //char[] playerChars = { 'X', 'O' };

            //foreach (char playerChar in playerChars)
            //{
            //    if (
            //        (playField[0, 0] == playerChar && playField[0, 1] == playerChar && playField[0, 2] == playerChar) ||
            //        (playField[1, 0] == playerChar && playField[1, 1] == playerChar && playField[1, 2] == playerChar) ||
            //        (playField[2, 0] == playerChar && playField[2, 1] == playerChar && playField[2, 2] == playerChar) ||
            //        (playField[0, 0] == playerChar && playField[1, 0] == playerChar && playField[2, 0] == playerChar) ||
            //        (playField[0, 1] == playerChar && playField[1, 1] == playerChar && playField[2, 1] == playerChar) ||
            //        (playField[0, 2] == playerChar && playField[1, 2] == playerChar && playField[2, 2] == playerChar) ||
            //        (playField[0, 0] == playerChar && playField[1, 1] == playerChar && playField[2, 2] == playerChar) ||
            //        (playField[0, 2] == playerChar && playField[1, 1] == playerChar && playField[2, 0] == playerChar)
            //    )
            //    {
            //        if(playerChar == 'X')
            //        {
            //            Console.WriteLine("\n Player 2 won");
            //        }
            //        else
            //        {
            //            Console.WriteLine("\n Player 1 won");
            //        }
            //        break;
            //    }
            //}

            //#endregion


            //    do
            //    {
            //        Console.WriteLine("\nPlayer {0} choose your field!", player);

            //        try
            //        {
            //            input = Convert.ToInt32(Console.ReadLine());

            //        }
            //        catch (Exception)
            //        {

            //            Console.WriteLine("Please enter a number");
            //        }
            //        if ((input == 1) && (playField[0, 0] == '1'))
            //        {
            //            inputCorrect = true;
            //        }
            //        else if ((input == 2) && (playField[0, 1] == '2'))
            //            inputCorrect = true;
            //        else if ((input == 3) && (playField[0, 2] == '3'))
            //            inputCorrect = true;
            //        else if ((input == 4) && (playField[1, 0] == '4'))
            //            inputCorrect = true;
            //        else if ((input == 5) && (playField[1, 1] == '5'))
            //            inputCorrect = true;
            //        else if ((input == 6) && (playField[1, 2] == '6'))
            //            inputCorrect = true;
            //        else if ((input == 7) && (playField[2, 0] == '7'))
            //            inputCorrect = true;
            //        else if ((input == 8) && (playField[2, 1] == '8'))
            //            inputCorrect = true;
            //        else if ((input == 9) && (playField[2, 2] == '9'))
            //            inputCorrect = true;
            //        else
            //        {
            //            Console.WriteLine("\n Incorrext input! Please do it again");
            //            inputCorrect = false;   
            //        }
            //    } while (!inputCorrect);


            //}
            //while (true);
            //int[,] array2D = new int[,]
            //{
            //     {1, 2, 3 },// row 0
            //    { 4, 5, 6 },//row 1
            //    { 6, 7, 8 }// row 2
            //};

            //for (int i = 0; i < array2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2D.GetLength(1); j++)
            //    {
            //        if ((j ==1) && (i ==0 || i==1 || i ==2))
            //        {
            //            Console.WriteLine(array2D[i,j]);
            //        }
            //    }
            //}



            /// Jagged Array's;
            /// kako se deklarira vo delot kaj so imam 3 to znacit deka imat 3 nizi vnatre
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[5];
            //jaggedArray[1] = new int[3];
            //jaggedArray[2] = new int[2];

            //jaggedArray[0] = new int[] { 2, 3, 4, 5, 7, 11 };
            //jaggedArray[1] = new int[] { 1, 2, 3 };
            //jaggedArray[2] = new int[] { 13, 14 };

            //vtor nacin
            //  int[][] jaggedArray2 = new int[][]
            //  {
            //      new int [] { 1, 2, 3, 4, 5},//row 1
            //      new int [] {11,12, 13, 14}// row 2
            //  };
            //  Console.WriteLine("Entry of {0}",jaggedArray2[1][3]);


            //for (int i = 0; i < jaggedArray2.Length; i++)
            //  {
            //      Console.WriteLine("Elements of {0}",i);
            //      for (int j = 0; j < jaggedArray2[i].Length; j++)
            //      {
            //          Console.Write(jaggedArray2[i][j]+ " ");
            //      }
            //      Console.WriteLine();
            //  }
            //string[] mamaArr = new string[]
            //{
            //    "Novica","Trajan"
            //};
            //string[][] friendsArr = new string[][]
            //{
            //    new string[] {"Petar"},
            //    new string[] {"Gorde","Gjoko"},
            //    new string[] {"Toni","Dimitar"},
            //   mamaArr
            //};

            //Console.WriteLine("Father of {0} its {1}", friendsArr[0][0], friendsArr[1][1]);

            //Console.WriteLine("MOther of {0} is {1}", friendsArr[0][0], friendsArr[1][0]);
            //Console.WriteLine("And two cousn's are {0} and {1}", friendsArr[2][0], friendsArr[2][1]);
            //Console.WriteLine("And grandparents of {0} are {1} {2}", friendsArr[0][0], friendsArr[3][0], friendsArr[3][1]);



            //Console.WriteLine("Price is {0}, pi its {1} at is {2}",32,3.14,'@');
            //Console.WriteLine();
        }
    }
}