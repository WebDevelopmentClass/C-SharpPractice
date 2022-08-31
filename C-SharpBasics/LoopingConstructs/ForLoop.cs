using System;
using System.Collections.Generic;
using System.Text;

namespace LoopingConstructs
{
    internal class ForLoop
    {
        public void ForLoopOperation()
        {
            string[] names = { "John", "Adam", "Nick", "Paolo", "Emily" };

            // From index 0
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine("\n");
            // From index 1
            for (int i = 1; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }


            // Initialize // condition / Increament decreament
        }

        public void ForeachLoop()
        {
            string[] names = { "John", "Adam", "Nick", "Paolo", "Emily" };

            foreach (var userName in names)
            {
                Console.WriteLine(userName);
            }
        }


    }
}
