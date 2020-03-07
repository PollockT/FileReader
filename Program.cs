using System;

namespace HealthRecords
{
    class Program
    {

        static void Main(string[] args)
        {
            string fname;
            string lname;
            string gender;
            double height;
            double weight;
            int birthyear;
            int currentyear;

            Console.Write("Enter client's first name: ");
            fname = Console.ReadLine();
            Console.Write("Enter the last name: ");
            lname = Console.ReadLine();
            Console.Write("Enter the client's gender:");
            gender = Console.ReadLine();
            Console.Write("What is the client's height in inches:");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the weight:");
            weight = double.Parse(Console.ReadLine());
            Console.Write("Enter Birth year:");
            birthyear = int.Parse(Console.ReadLine());
            Console.Write("Enter the current year:"); 
            currentyear = int.Parse(Console.ReadLine());

            client joe = new client(fname, lname, gender, height, weight, birthyear, currentyear);
            joe.DisplayInfo(); 


        }
    }
}
