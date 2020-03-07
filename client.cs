using System;
using System.Collections.Generic;
using System.Text;

namespace HealthRecords
{
    class client
    {
        //data 
        private string fname;
        private string lname;
        private string gender;
        private double height;
        private double weight;
        private int birthyear;
        private int currentyear;

        public client(string fname, string lname, string g, double h,

            double w, int birthyear, int curryear)
        {
            //to refer to the instance variable use this 
            this.fname = fname;
            this.lname = lname;
            gender = g;
            this.height = h;
            weight = w;
            this.birthyear = birthyear;
            currentyear = curryear;

        }

        public string getFname()
        {
            return fname;
        }

        public string getLname()
        {
            return lname; 

        }


        public string getGender ()
        {
            return gender; 
        }

        public double getHeight()
        {
            return height; 
        }

        public double getWeight()
        {
            return weight; 
        }
        public int getBirthYear()
        {
            return birthyear; 
        }

        public int getCurrentYear()
        {
            return currentyear; 
        }
        private double calculateBMI()
        {
            double bmi = 0.0;
            bmi = (weight/Math.Pow(height,2) * 703) ; 
            return bmi; 
        }
        public void DisplayInfo()
        {
            double bmi =  calculateBMI(); 
            Console.WriteLine($"Health Record For: {fname} {lname}"); 
        }



    }//class 


} //namespace 