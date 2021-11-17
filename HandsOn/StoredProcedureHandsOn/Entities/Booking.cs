using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedureHandsOn
{
    class Booking
    {
        public long BookingId { get; set; }
        public DateTime BookDate { get; set; }

        public List<Ticket> tickets = new List<Ticket>();

        public User user { get; set; } = new User();

        public Show show { get; set; } = new Show();

    }
}
