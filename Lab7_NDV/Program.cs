using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GC_CLassroom;

namespace Lab7_NDV
{
  public  class Program
    {
       public static void Main(string[] args)
        {

            Classroom expNet = new Classroom();
            Classroom javaClass = new Classroom();
            string Anw;


            Console.WriteLine("Welcome to our .Net class. Which student would you like to klnow about?");
            Console.WriteLine("Enter a Number between 1 and 20");
            string student =Console.ReadLine();
            int studentNum = int.Parse(student);

            while (studentNum > 20) 
            {
                Console.WriteLine("Out of Rang");

                Console.WriteLine("Enter a Number between 1 and 20");
                 student = Console.ReadLine();
                 studentNum = int.Parse(student);


            } 


                Console.WriteLine("Student " + studentNum + " is " + expNet.m_Student[studentNum].Name);

            
            
              
                    Console.WriteLine("What would you like to know about " + expNet.m_Student[studentNum].Name + "? \nEnter: 1 for 'homeTown', 2 for 'favorite food' 3 for 'age'");

                string info = Console.ReadLine();
                int infoNum = int.Parse(info);
            while (!(info == "1" || info == "2" || info == "3"))
            {
                Console.WriteLine("Non data. Please enter 1, 2 or 3");

                info = Console.ReadLine();
                infoNum = int.Parse(info);
            }

                do
                { 



                    if (info == "1")
                    {
                        Console.WriteLine(expNet.m_Student[studentNum].HomeTown);
                    }
                    else if (info == "2")
                    {
                        Console.WriteLine(expNet.m_Student[studentNum].FavFood);
                    }
                    else if (info == "3")
                    {
                        Console.WriteLine(expNet.m_Student[studentNum].Age);


                    }
                    Console.WriteLine("would you like to know more? (yes/no)");
                    Anw = Console.ReadLine().ToLower();
                } while (Anw == "yes");

                Console.WriteLine("Thanks!");
            

            



        }
    }
}
