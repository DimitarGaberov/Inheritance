using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Man_kind
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var firstName = inputLine[0];
            var lastName = inputLine[1];
            var facultyNumber = inputLine[2];
            Student student;
            try
            {
                student = new Student(firstName, lastName, facultyNumber);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            inputLine = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            firstName = inputLine[0];
            lastName = inputLine[1];
            var weekSalary = decimal.Parse(inputLine[2]);
            var hoursPerDay = int.Parse(inputLine[3]);
            Worker worker;
            try
            {
                worker = new Worker(firstName, lastName, weekSalary, hoursPerDay);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }

            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
    }
}
