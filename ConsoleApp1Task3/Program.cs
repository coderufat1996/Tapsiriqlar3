using System.ComponentModel.Design;

namespace ConsoleApp1Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int say;
        l1:
            Console.Write("Telebe sayini daxil edin:");
            if (!int.TryParse(Console.ReadLine(), out say) || say <= 0) 
                    {
                goto l1;
            }
            Student[] telebe = new Student[say];
            for (int i = 0; i < telebe.Length; i++)
            {
                Student student = new Student();
                student.name = Helper.Readstring($"{i + 1}.name:");
                student.surname = Helper.Readstring($"{i + 1}.surname:");
                student.age = Helper.Readint($"{i + 1}.age:");
                student.speciality = Helper.Readstring($"{i + 1}.speciality:");
                student.groupNo = Helper.Readint($"{i + 1}.groupNo:");
                telebe[i] = student;
                

            }
            Console.WriteLine("---------------------");
            for (int i = 0; i < telebe.Length; i++)
            {
                Console.Write($"{i + 1},");
                Console.WriteLine(telebe[i]);
            }

                    
            


        }
    }
}