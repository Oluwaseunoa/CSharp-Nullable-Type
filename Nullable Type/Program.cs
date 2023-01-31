using System;
namespace TutorialsPoint_ConsoleApp
{
    class Program
    {
        static void Main()
        {

            int? ticketsOnSale = 200;

            int availableTickets = ticketsOnSale ?? 0;

            Console.WriteLine("Available Ticket = {0}", availableTickets);

            // int availableTickets;

            //if(ticketOnSale == null)
            //{
            //    availableTickets = 0;
            //}
            //else
            //{
            //    availableTickets = (int)ticketOnSale;
            //}

            //Console.WriteLine("Available Ticket = {0}", availableTickets
            //    );


            //bool? areYouMajor = true;

            //if (areYouMajor == true)
            //{
            //    Console.WriteLine("User is Major");
            //}
            //else if (areYouMajor == false) 
            //{
            //    Console.WriteLine("User not Major");
            //}
            //else
            //{
            //    Console.WriteLine("User did not answer the question");
            //}
        }
    }
}