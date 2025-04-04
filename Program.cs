using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Functions
{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            //var name = new string[3] { "Hello", "This ", "is" };
            //var format = string.Join(",", name);
            //Console.WriteLine(format);

            //var arr = new int[3] { 1, 2, 3 };
            //var arr2 = arr;
            //arr2[0] = 0;

            //Console.WriteLine(string.Format("array is {0} , arr2 is: {1} " , arr[0], arr2[0]));
            //var person= new Person() { age = 10} ;
            

            //MakeOld(person);
            //Console.WriteLine(person.age);

           //string  numnber = Console.ReadLine();

           // if (Convert.ToInt32(numnber) > 1 && Convert.ToInt32(numnber) <= 10) {
           //     Console.WriteLine("valid");
           // }
           // else
           // {
           //     Console.WriteLine("Not valid");
           // }

            //int  n =Convert.ToInt32(Console.ReadLine());    
            //int x = Convert.ToInt32(Console.ReadLine());    

            //if(n > x)
            //{
            //    Console.WriteLine(n);
            //}
            //else
            //{

            //    Console.WriteLine(x);
            //}

            //var name ="SahilMohite";

            //foreach(var names in name)
            //{
            //    Console.Write(names + " ");
            //}


            var random = new Random();
            for(var i=0;i <10; i++)
            {
                Console.Write(random.Next( 1 , 10));
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++) { 
                Console.Write((char)random.Next(97, 122) + " "); 
            }


            var number = new List<int>() { 1 , 2 , 3 , 4};   

            number.Add(1);

            number.AddRange(new int[3] { 5, 6, 7 });


            foreach(var numbers in number)
            {
                Console.WriteLine(numbers);
            }


            Console.WriteLine(number.IndexOf(1));
            Console.WriteLine(number.LastIndexOf(2));





        }
    }
}
