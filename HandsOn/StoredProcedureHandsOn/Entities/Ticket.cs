using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedureHandsOn
{
    class Ticket
    {
        public long TicketId { get; set; }
        public List<Seat> seats = new List<Seat>();

        public Booking booking { get; set; } = new Booking();
    }
}
