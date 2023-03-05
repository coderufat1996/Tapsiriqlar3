using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Task3
{
    internal class Helper
    {
        static public string Readstring(string question)
        {
        l1:

            Console.Write(question);
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                goto l1;
            }
            return name;
        }





        static public string Readstring(string question)
        {
        l2:

            Console.Write(question);
            string surname = Console.ReadLine();
            if (string.IsNullOrEmpty(surname))
            {
                goto l2;
            }
            return surname;

        }

        static public int Readint(string question)
        {
        l1:
            int age;
            Console.Write(question);
            if (!int.TryParse(Console.ReadLine(), out age))
                    {
                Console.WriteLine("Eded daxil edilmelidir:");
                goto l1;
            }
            return age;
        }


        static public string Readstring(string question)
        {
        l1:

            Console.Write(question);
            string speciality = Console.ReadLine();
            if (string.IsNullOrEmpty(speciality))
            {
                goto l1;
            }
            return speciality;
        }


        static public int Readint(string question)
        {
        l2:
            int groupNo;
            Console.Write(question);
            if (!int.TryParse(Console.ReadLine(), out groupNo))
            {
                Console.WriteLine("Eded sehv daxil edilmisdir:");
                goto l2;
            }
            return groupNo;

        }



        }
}

