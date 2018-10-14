using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            Boolean bret;

            Console.WriteLine("Enter the Password");
            str = Console.ReadLine();

            MarvellousAuthentication obj = new MarvellousAuthentication(str);
            bret = obj.ChkPassword();

            try
            {
                if(bret==false)
                {
                    InvalidException ob = new InvalidException("password is not correct");
                    throw ob;

                }
                else
                {
                    Console.WriteLine("Password is Correct");
                }
            }
            catch(InvalidException e)
            {
                Console.WriteLine(e);
            }

            ///////////////////////////////////////////////////////////////////////////////
            //Q.2
            //
            //////////////////////////////////////////////////////////
            MarvellousEmployee emp = new MarvellousEmployee();
            try
            {
                emp.Accept();
            }
            catch(InvalidNameException e)
            {
                Console.WriteLine(e);
            }
            catch(InvalidAgeException e)
            {
                Console.WriteLine(e);
            }
            catch (BloodGroupInvalidException e)
            {
                Console.WriteLine(e);
            }
            emp.Display();
        }
    }
}
