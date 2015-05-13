using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NTestApi.Controllers
{
    [RoutePrefix("api/v2")]
    public class MetadataV2Controller : ApiController
    {
        // GET: api/v2/datasets
        //		Url	"http://www.quandl.com/api/v2/datasets.json?query=*&source_code=WORLDBANK&per_page=300&page=1&auth_token=asdfasfadsf"


        [Route("")]
        [Route("datasets.json")]
        public MetadataResponseV2Test Get()
        {
            var queryCollection = HttpUtility.ParseQueryString(Request.RequestUri.Query);
            var query = queryCollection["query"];
            var source_code = queryCollection["source_code"];
            var per_page = queryCollection["per_page"];
            var page = queryCollection["page"];
            var auth_token = queryCollection["auth_token"];

            const string filePath = @"A:\DEVOPS\NQuandl\NQuandl.Generator\responses\";
            var fileName = source_code + page + ".json";
            var file = File.ReadAllText(filePath + fileName);

            var cacheResponse = new MetadataResponseV2Test
            {
                CacheResponse = new RequestCacheResponse(),
                // MetadataResponse = System.Web.Helpers.Json.Decode<MetadataResponseV2>(file)
            };
            RequestCache.AddEntryToRequestLog();
            return cacheResponse;
        }
    }

    public class RequestCacheResponse
    {
        public DateTime FirstRequestTime
        {
            get { return RequestCache.FirstRequestTime; }
        }

        public DateTime LastRequestTime
        {
            get { return RequestCache.LastRequestTime; }
        }

        public TimeSpan TimeElapsed
        {
            get { return LastRequestTime - FirstRequestTime; }
        }

        public TimeSpan AverageTimeBetweenRequests
        {
            get { return RequestCache.AverageTimeBetweenRequests; }
        }

        public RequestLogEntry LastEntry
        {
            get { return RequestCache.LastEntry; }
        }

        public int RequestCount
        {
            get { return RequestCache.RequestCount; }
        }

        public double RequestsPerSecond
        {
            get
            {
                return RequestCache.Log.Any()
                    ? RequestCache.Log.Count(x => x.RequestTime >= DateTime.Now.AddSeconds(-1))
                    : 0;
            }
        }

        public double AverageRequestsPerSecond
        {
            get
            {
                if (RequestCount != 0)
                {
                    return RequestCount / TimeElapsed.TotalSeconds;
                }
                return 0;
            }
        }

        public TimeSpan TimeElapsedSinceFirstRequest
        {
            get { return DateTime.Now - RequestCache.FirstRequestTime; }
        }

        public double RequestsPerLastTenMinutes
        {
            get
            {
                return RequestCache.Log.Any()
                    ? RequestCache.Log.Count(x => x.RequestTime >= DateTime.Now.AddMinutes(-10))
                    : 0;
            }
        }

        public double EstimatedRequestsPer10MinutesAtCurrentRate
        {
            get { return RequestsPerSecond*600; }
        }

        public double EstimatedAverageRequestsPer10MinutesAtCurrentRate
        {
            get { return AverageRequestsPerSecond * 600; }
        }

        public int RequestsRemaining
        {
            get
            {
              
                if (TimeElapsed.Seconds <= 600)
                {
                    return 2000 - RequestCache.Log.Count(x => x.RequestTime >= DateTime.Now.AddMinutes(-10));
                }
                var tenMinutesElapsed = Math.Floor((double) (TimeElapsed.Seconds / 600));
                return 2000 - RequestCache.Log.Count(x => x.RequestTime >= DateTime.Now.AddMinutes(-10 * tenMinutesElapsed)); ;
            }
        }
    }

    public static class RequestCache
    {
        public static object FirstRequestTimeCache
        {
            get { return HttpContext.Current.Cache["FirstRequestTime"]; }
            set { HttpContext.Current.Cache["FirstRequestTime"] = value; }
        }

        public static DateTime FirstRequestTime
        {
            get
            {
                if (FirstRequestTimeCache != null) return (DateTime) FirstRequestTimeCache;
                if (Log.FirstOrDefault() == null) return DateTime.Now;

                var requestTime = Log.OrderBy(x => x.RequestTime).First().RequestTime;
                FirstRequestTimeCache = requestTime;
                return requestTime;
            }
        }


        public static object RequestCountCache
        {
            get { return HttpContext.Current.Cache["RequestCount"]; }
            set { HttpContext.Current.Cache["RequestCount"] = value; }
        }

        public static int RequestCount
        {
            get { return (int?) RequestCountCache ?? 0; }
        }

        public static object LogCache
        {
            get { return HttpContext.Current.Cache["RequestLog"]; }
            set { HttpContext.Current.Cache["RequestLog"] = value; }
        }

        public static List<RequestLogEntry> Log
        {
            get
            {
                if (LogCache == null)
                {
                    LogCache = new List<RequestLogEntry>();
                }
                return (List<RequestLogEntry>) LogCache;
            }
        }

        public static RequestLogEntry LastEntry
        {
            get { return Log.Any() ? Log.OrderBy(x => x.RequestTime).Last() : null; }
        }

        public static object LastRequestTimeCache
        {
            get { return HttpContext.Current.Cache["LastRequestTime"]; }
            set { HttpContext.Current.Cache["LastRequestTime"] = value; }
        }

        public static DateTime LastRequestTime
        {
            get
            {
                if (LastRequestTimeCache == null)
                {
                    LastRequestTimeCache = DateTime.Now;
                }
                return (DateTime) LastRequestTimeCache;
            }
        }

        public static TimeSpan AverageTimeBetweenRequests
        {
            get
            {
                var log = Log;

                if (log == null) return new TimeSpan(0);
                log = log.ToList();
                if (!log.Any()) return new TimeSpan();
                var average = log.Select(x => x.TimeSinceLastRequest).Average(x => x.Ticks);
                return new TimeSpan(Convert.ToInt64(average));
            }
        }

        public static RequestLogEntry AddEntryToRequestLog()
        {
            RequestCountCache = RequestCount + 1;
            var entry = new RequestLogEntry();
            Log.Add(entry);
            return entry;
        }
    }


    public class RequestLogEntry
    {
        public TimeSpan CurrentAverageTimeBetweenRequests;
        public DateTime LastRequestTime;
        public int RequestId;
        public DateTime RequestTime;
        public TimeSpan TimeSinceLastRequest;

        public RequestLogEntry()
        {
            LastRequestTime = RequestCache.LastRequestTime;
            RequestTime = DateTime.Now;
            RequestId = RequestCache.RequestCount;
            TimeSinceLastRequest = RequestTime - LastRequestTime;
            CurrentAverageTimeBetweenRequests = RequestCache.AverageTimeBetweenRequests;
            RequestCache.LastRequestTimeCache = RequestTime;
        }
    }

    public class MetadataResponseV2Test
    {
        public MetadataResponseV2 MetadataResponse { get; set; }
        public RequestCacheResponse CacheResponse { get; set; }
    }

    public class MetadataResponseV2
    {
        public int total_count { get; set; }
        public int current_page { get; set; }
        public int per_page { get; set; }
        public Doc[] docs { get; set; }
        public Source[] sources { get; set; }
        public int start { get; set; }
        public object spellcheck { get; set; }
        public object[][] highlighting { get; set; }
    }

    public class Doc
    {
        public int id { get; set; }
        public int source_id { get; set; }
        public string source_code { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string urlize_name { get; set; }
        public object display_url { get; set; }
        public string description { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public DateTime refreshed_at { get; set; }
        public string frequency { get; set; }
        public string from_date { get; set; }
        public string to_date { get; set; }
        public string[] column_names { get; set; }
        public bool _private { get; set; }
        public object type { get; set; }
        public bool premium { get; set; }
    }

    public class Source
    {
        public int id { get; set; }
        public string code { get; set; }
        public int datasets_count { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string host { get; set; }
        public bool premium { get; set; }
    }
}