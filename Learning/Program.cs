using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPattern
{
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return "My name is " + Name;
        }
        ~Person()
        {
            Name = string.Empty;
        }
    }
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
        }
        public void Study()
        {
            Console.WriteLine("I'm Studying");
        }
    }
    public class Teacher : Person
    {
       public Teacher(string name) : base(name)
       {
       }
        public void Explain()
        {
            Console.WriteLine("I'm Explaining");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            total = int.Parse(Console.ReadLine());

            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Enter name of Teacher");
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Enter name of Student");
                    persons[i] = new Student(Console.ReadLine());
                }
            }

            for(int i = 0; i < total; i++)
            {
                if (i == 0)
                {
                    ((Teacher)persons[i]).Explain(); // Type cast (telling that the object of persons[i] have to be treated as Teacher & then we can call the methods of Teacher)
                }
                else
                {
                    ((Student)persons[i]).Study(); // Type cast (telling that the object of persons[i] have to be treated as Student)
                }
            }
            Console.ReadLine();
        }

    }
}
