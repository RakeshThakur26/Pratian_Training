using StoredProcedureHandsOn.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedureHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            ITicketBookingService ticket = new TicketBookingService();
            //Movie movie1 = new Movie();
            //Console.WriteLine("Enter movie Id");
            //movie1.MovieId = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("Enter movie Name");
            //movie1.MovieName = Console.ReadLine();

            //ticket.InsertMovie(movie1);

            // ticket.UpdateMovie(124421, "Sanket Kalla");

            // ticket.DeleteMovie(124421);


            //Theatre t1 = new Theatre();
            //t1.TheatreId = 1111;
            //t1.TheatreName = "Inox";
            //Theatre t2 = new Theatre();
            //t2.TheatreId = 2222;
            //t2.TheatreName = "Imax";

            //ticket.InsertTheatre(t1);
            //ticket.InsertTheatre(t2);


            // ticket.UpdateTheatre(1111, "4K");

            // ticket.DeleteTheatre(1111);

            //Screen screen1 = new Screen();
            //screen1.ScreenId = 777;
            //screen1.ScreenName = "Big screen";
            //screen1.theatre.TheatreId = 1111;

            //ticket.InsertScreen(screen1);

            // ticket.UpdateScreen(777, "Wide screen");

            // ticket.DeleteScreen(888);



            Console.Read();
        }
    }
}
