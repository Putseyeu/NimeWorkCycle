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
            

            for (totalRepeat = Convert.ToInt32(Console.ReadLine()); totalRepeat > 0; totalRepeat -=1 )
            {
                Console.WriteLine(messageUser);
            }
        }
    }
}
