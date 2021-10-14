using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeWorkCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            string messageUser;
            int totalRepeat;

            Console.Write("What's your message ?: ");
            messageUser = Console.ReadLine();
            Console.Write("How many times to repeat it ?:");
            totalRepeat = Convert.ToInt32(Console.ReadLine());

            while ( totalRepeat --> 0)
            {
                Console.WriteLine(messageUser);
            }
        }

    }
}
