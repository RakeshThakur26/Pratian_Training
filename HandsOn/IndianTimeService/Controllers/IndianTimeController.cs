using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IndianTimeService.Controllers
{
    public class IndianTimeController : ApiController
    {
        public string GetTime()
        {
            return DateTime.Now.ToLongTimeString();
        }
    }
}
