using System;

namespace OOP2Tutorial_2_part2
{
    public class ValueOutOfBoundException:Exception
    {
        public ValueOutOfBoundException(string msg) : base(msg)
        {
            
        }
    }
}