using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedureHandsOn
{
    class Theatre
    {
        public int TheatreId { get; set; }
        public string TheatreName { get; set; }

        public List<Screen> screen = new List<Screen>();


    }
}
