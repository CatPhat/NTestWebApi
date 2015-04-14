using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NTestApi.Controllers
{
    [RoutePrefix("api/testapi2")]
    public class TestApi2Controller : ApiController
    {

        public int CurrentCount { get; set; }

        // GET: v1
        [HttpGet]
        public Time2 Get()
        {
            var cachedCount = (int?)HttpContext.Current.Cache["requestCount"] ?? 0;
            var random = new RandomNumber();
            cachedCount = cachedCount + 1;
            HttpContext.Current.Cache["requestCount"] = cachedCount;
            return new Time2 { RequestCount = cachedCount, UniqueId2 = random.Next(new Random().Next()).ToString()};

        }
    }

    

    public class Time2
    {
        public string RequestType
        {
            get { return "TIME2"; }
        }

        public string UniqueId2 { get; set; }
        public int RequestCount { get; set; }
        public int Hour { get { return DateTime.Now.Hour; } }
        public int Minute { get { return DateTime.Now.Minute; } }
        public int Second { get { return DateTime.Now.Second; } }
        public int Milliseconds { get { return DateTime.Now.Millisecond; } }
    }
}