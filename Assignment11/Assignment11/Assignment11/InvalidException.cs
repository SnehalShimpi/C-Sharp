using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    class InvalidException : Exception
    {
        public InvalidException(string str):base(str)
        {
            String abc = str;
            Console.WriteLine("{0}",abc);

        }
    }
   public class InvalidNameException :Exception
    {
        public InvalidNameException(string str) : base(str)
        {
            String abc = str;
            Console.WriteLine("{0}", abc);

        }

    }
  public  class InvalidAgeException:Exception
    {
        public InvalidAgeException(string str) : base(str)
        {
            String abc = str;
            Console.WriteLine("{0}", abc);

        }

    }
    public class BloodGroupInvalidException : Exception
    {
        public BloodGroupInvalidException(string str) : base(str)
        {
            String abc = str;
            Console.WriteLine("{0}", abc);

        }

    }
}
