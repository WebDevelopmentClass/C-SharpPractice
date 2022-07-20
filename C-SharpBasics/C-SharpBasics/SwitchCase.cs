using System;
using System.Collections.Generic;
using System.Text;

namespace C_SharpBasics
{
    internal class SwitchCase
    {
        // if(operation ==  '+')
        // {
        // a+b} else if (operation == '-'){a-b} else if(oepration == '*'){a*b}

        public int SwitchCaseOperations(int firstNumber, int secondNumber, char operations)
        {
            switch (operations)
            {
                case '+':
                    return Add(firstNumber, secondNumber);
                case '-':
                    return Subtract(firstNumber, secondNumber);

                case '*':
                    return Mulitply(firstNumber, secondNumber);

                case '/':
                    return Divide(firstNumber, secondNumber);

                default:
                    return 0;
            }
        }



        public int Add(int a , int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Mulitply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
