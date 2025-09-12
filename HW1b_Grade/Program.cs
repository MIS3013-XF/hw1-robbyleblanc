// HW1b Grade

// Your Name: Robert LeBlanc
// Did you seek help ? If yes, specify the helper or web link here: Pooja

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("What is your student ID?");
            string studentid = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            double homeworks = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participations?");
            double participation = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            double quizzes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            double midterm = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for the final?");
            double final = Convert.ToDouble(Console.ReadLine());

            double homeworkpercentage = 0.20;
            double participationrate = 0.15; 
            double exam1 = 0.25;
            double quiz = 0.15;
            double examfinal = 0.25;

            double Finalgrade = ((homeworks * homeworkpercentage) + (participation * participationrate) + (quizzes * quiz) + (midterm * exam1) + (final * examfinal));

            Console.WriteLine(firstname + " " + lastname + "Your final grade is" + Finalgrade);

            Console.ReadKey();
        


        }
    }
}
