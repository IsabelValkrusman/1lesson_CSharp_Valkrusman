using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1lesson_CSharp_Valkrusman
//{
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Hello world");
//    Console.BackgroundColor = ConsoleColor.Cyan; //värvib fooni
//    Console.ForegroundColor = ConsoleColor.Black;
//    Random rnd = new Random(); //võib sõltuda tähendusest/arvust mis on sulgudes, ei pea kirjutama sulgudesse ka
//    Console.WriteLine("jah-random, ei-ise sisestan number");
//    string soov = Console.ReadLine();
//    int num=0;
//    if (soov == "jah")
//    {
//        num = rnd.Next(1, 8);//toob välja random täisarvu
//    }
//    else
//    {
//        try
//        {
//            num = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Päeva number: {0}", num.ToString());
//        }
//        catch (SystemException)
//        {
//        }
//}
//string nimetus = "";
//switch (num)
//{
//    case 1: nimetus = "esmaspäev"; break;
//    case 2: nimetus = "teisipäev"; break;
//    case 3: nimetus = "kolmapäev"; break;
//    case 4: nimetus = "neljapäev"; break;
//    case 5: nimetus = "reede"; break;
//    case 6: nimetus = "laupäev"; break;
//    case 7: nimetus = "pühapäev"; break;
//    default: // see on nagu else pythonis!
//        nimetus = "Viga!";
//        break;
//}
//Console.WriteLine(nimetus);
//StreamWriter filesse = new StreamWriter(@"..\..\andmed.txt",true);
//filesse.WriteLine("Number oli {0}, päev on {1}", num.ToString(), nimetus);
//filesse.Close();
//Console.WriteLine("failis oli salvestatud: Number oli" + num.ToString() + "päev on" + nimetus);
//StreamReader filest = new StreamReader(@"..\..\andmed.txt");
//string a = filest.ReadToEnd();
//Console.WriteLine("Failis oli seda: \n" + a);


//Console.Clear();
//Console.WriteLine(nimetus);
//Console.ReadLine();

//        }
//    }
//}




//{
//    class Program
//    {
//         static void Main(string[] args)
//        {
//            string num1 = Console.ReadLine();
//            string num2 = Console.ReadLine();
//            string num = Console.ReadLine();
//            double num1 = 7.543544;
//            num1 = Math.Round(num1, 5);
//            double num2 = 4.573544;
//            num2 = Math.Round(num2, 5);
//            num = 2 * num1 + num2/11 * num1 - 13 * num2;
//            Console.WriteLine(num1.ToString());
//            Console.WriteLine(num2.ToString());
//            Console.WriteLine(num.ToString());
//            Console.BackgroundColor = ConsoleColor.Cyan; 
//            Console.ForegroundColor = ConsoleColor.Black;
//            Console.ReadKey();
//        }
//    }
//}



//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("sisesta muutuv osa");
//            string soov = Console.ReadLine();




//            Console.WriteLine("");
//            Random kon = new Random();
//            string kon= Console.ReadLine();
//            int num = 0;
//            if
//                 Console.WriteLine("Vale");

            
//        num = rnd.Next(1, 5);

//        case 1: nimetus = ""; break;





//         }
//    }
//}


//private static void Main(string[] args)
//{
//    {
//        {

//           Console.WriteLine("Sisesta a ");
//           var a = Convert.ToInt32(Console.ReadLine());
//           Console.WriteLine("Sisesta b ");
//           var b = Convert.ToInt32(Console.ReadLine());

//           var c = (2 * a + b / 11 * a - 13 * b);
//           Console.WriteLine("c = 2 * a + b / 11 * a - 13 * b \n");
//           File.WriteAllText(@"..\..\andmed.txt", c.ToString());
//           Console.ReadLine();
//        }
//   }
//}




{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            string[] sonad = new string[7] { "aa", "bb", "cc", "dd", "ee", "ff", "gg" };
            foreach (string sona in sonad)
            {
                Console.WriteLine(sona);
            }
            for (int i = 0; i < sonad.Length; i++)
            {
                Console.WriteLine(sonad[i]);//1-7 

            }
            do

            Console.WriteLine("vajuta escape");

            Key = Console.ReadKey(),
            } while (Key.key != ConsoleKey.Escape) ;



            Console.ReadKey();
 
         }
    }
}
   