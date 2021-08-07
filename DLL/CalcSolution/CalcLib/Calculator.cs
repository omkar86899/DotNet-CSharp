using System;

namespace CalcLib
{
    public class Calculator
    {
        public Boolean CheckEven(int no)
        {
            return no % 2 == 0;
        }
        public Boolean CheckPrime(int no)
        {
            if (no < 0)
            {
                return false;
            }
            for(int i = 2; i <= no/2; i++)
            {
                if (no % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
