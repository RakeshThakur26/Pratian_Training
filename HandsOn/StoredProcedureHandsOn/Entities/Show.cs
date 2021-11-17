using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedureHandsOn
{
    class Show
    {
        public int ShowId { get; set; }
        public DateTime ShowTime { get; set; }
        public double Cost { get; set; }

        public Movie movie { get; set; } = new Movie();
        public Screen screen { get; set; } = new Screen();

        public List<Booking> booking = new List<Booking>();
    }
}
