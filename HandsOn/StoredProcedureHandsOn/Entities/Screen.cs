using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedureHandsOn
{
    class Screen
    {
        public int ScreenId { get; set; }
        public string ScreenName { get; set; }

        public Theatre theatre { get; set; } = new Theatre();
        public List<Seat> seats = new List<Seat>();

        public List<Show> shows = new List<Show>();
    }
}
