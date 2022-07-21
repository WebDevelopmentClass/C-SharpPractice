using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalStatements
{
    internal class Opstate
    {
        public bool ConditionalState(char a)
        {

            if (a == 'a' || a == 'A' || a == 'e' || a =='E' || a == 'i' || a == 'I' || a == 'o' || a == 'O' || a == 'u' || a == 'U')
                return true;
            else 
                return false;
        }
        public int MaxThreeNumbers(int a, int b, int c)
        {
            if (a>b && a>c)
                return a;
            else if (b>c && b>a)
                return b;
            else
                return c;
                
        }
    }
}
