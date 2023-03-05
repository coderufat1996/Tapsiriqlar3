using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Task3
{
    internal class Student
       
    {   
    }
    public string name;
    public string surname;
    public int age;
    public string speciality;
    public string groupNo;

    public override string ToString()
    {
        return $"{name} {surname} {age} {speciality} {groupNo}";
    }
}
