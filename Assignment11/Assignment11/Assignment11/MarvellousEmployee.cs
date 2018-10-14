using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class MarvellousEmployee
    {
        public string EName;
        public int EAge,name,BG;
        public string EBloodGroup;
        public void Accept()
        {
            Console.WriteLine("Enter the Employee Name");
            EName = Console.ReadLine();

            Console.WriteLine("Enter the Employee Age");
            EAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Blood Group Employee");
            EBloodGroup = Console.ReadLine();

            foreach (char ch in EName)
            {
                if (((ch >= 'A') && (ch <= 'Z')) || ((ch>='a') && (ch<='z')))
                {
                    name = 1;
                }
                else
                {
                    name = 0;
                }
            }
            foreach (char ch in EBloodGroup)
            {
                 
                
                if (ch == 'O' || ch == 'A' || ch == 'B')
                {
                    BG = 1;
                }
                
                else
                {
                    BG = 0;
                }
            }
            if (EAge<=0)
            {
                InvalidAgeException ob1 = new InvalidAgeException("Age is Should be Positive");
                throw ob1;

            }
            if(name==0)
            {
                InvalidNameException ob2 = new InvalidNameException("Name Should not Contain Speacial Character");
                throw ob2;
            }
            if(BG==0)
            {
                BloodGroupInvalidException ob3 = new BloodGroupInvalidException("Enter Apropriate Blood Group");
                throw ob3;
            }
            
       
    }
        public void Display()
        {
            Console.WriteLine("Name of Employee is {0}", EName);
            Console.WriteLine("Age of Employee is {0}", EAge);
            Console.WriteLine("BloodGroup of Employee is {0}", EBloodGroup);
        }
    }
}
