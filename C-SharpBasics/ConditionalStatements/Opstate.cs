using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionalStatements
{
    internal class Opstate
    {
        public bool ConditionalSate( int a)
        {

            if (a == 'a' || a == 'A' || a == 'e' || a =='E' || a == 'i' || a == 'I' || a == 'o' || a == 'O' || a == 'u' || a == 'U')
                return true;
            else 
                return false;
        }
    }
}
