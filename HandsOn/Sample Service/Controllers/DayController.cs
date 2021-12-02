using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sample_Service.Controllers
{
    [RoutePrefix("api/day")]
    public class DayController : ApiController
    {
       
        public string GetFirst(int ID)
        {
            switch (ID)
            {
                case 1: return "Sunday";
                case 2: return "Monday";
                case 3: return "Tuesday";
                case 4: return "Wednesday";
                case 5: return "Thursday";
                case 6: return "Friday";
                case 7: return "Saturday";
                default: return "Wrong input";
            }       
        }
    }
   
}
