using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NTestApi.Controllers
{
    [RoutePrefix("api/testapi")]
    public class TestApiController : ApiController
    {

        public int CurrentCount { get; set; }

        // GET: v1
        [HttpGet]
        public Time Get()
        {
            var cachedCount = (int?)HttpContext.Current.Cache["requestCount"] ?? 0;
            var random = new RandomNumber();
            cachedCount = cachedCount + 1;
            HttpContext.Current.Cache["requestCount"] = cachedCount;
            return new Time { RequestCount = cachedCount, UniqueId = random.Next(new Random().Next())};

        }
    }

    public class RequestCount
    {
        public void Add()
        {
            
        }
    }

    public class RandomNumber
    {
        private static readonly Random Global = new Random();
        [ThreadStatic]
        private static Random _local;

        public int Next(int max)
        {
            var localBuffer = _local;
            if (localBuffer == null)
            {
                int seed;
                lock (Global) seed = Global.Next();
                localBuffer = new Random(seed);
                _local = localBuffer;
            }
            return localBuffer.Next(max);
        }
    }

    public class Time
    {
        public string RequestType
        {
            get { return "TIME1"; }
        }
        public int UniqueId { get; set; }
        public int RequestCount { get; set; }
        public int Hour { get { return DateTime.Now.Hour; } }
        public int Minute { get { return DateTime.Now.Minute; } }
        public int Second { get { return DateTime.Now.Second; } }
        public int Milliseconds { get { return DateTime.Now.Millisecond; } }
    }
}