using System;
using System.Collections.Generic;
using System.Text;

namespace C_SharpBasics
{
    internal class Conditional
    {
        /// <summary>
        /// Check if user is more than 18 or 25 or 30 
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public bool CheckAge(int age)
        {
            if (age > 18)
            {
                return true;
            }
            else if (age > 25)
            {
                return true;
            }
            else if(age > 30)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
    }
}
