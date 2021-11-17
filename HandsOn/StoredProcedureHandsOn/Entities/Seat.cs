using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedureHandsOn
{
    class Seat
    {
        public char RowId { get; set; }
        public int SeatId { get; set; }

        public Ticket ticket { get; set; } = new Ticket();
    }
}
