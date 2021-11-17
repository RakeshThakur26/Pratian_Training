using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedureHandsOn
{
    class User
    {
        public long UserId { get; set; }
        public string LoginName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address address { get; set; } = new Address();

        public List<Booking> bookings = new List<Booking>();
    }
}
