using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TambolaTicketGenerator;

namespace TambolaGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] ticket = new int[3, 9];
            TicketGenerator.GenerateTicket(ref ticket);
            TicketGenerator.PrintTicket(ticket);
            Console.ReadLine();
        }
    }
}
