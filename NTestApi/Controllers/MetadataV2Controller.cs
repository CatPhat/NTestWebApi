using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
        public string Get()
        {
            NameValueCollection queryCollection = HttpUtility.ParseQueryString(Request.RequestUri.Query);
            var query = queryCollection["query"];
            var source_code = queryCollection["source_code"];
            var per_page = queryCollection["per_page"];
            var page = queryCollection["page"];
            var auth_token = queryCollection["auth_token"];

            const string filePath = @"A:\DEVOPS\NQuandl\NQuandl.Generator\responses\";
            var fileName = source_code + page + ".json";

            var response = File.ReadAllText(filePath + fileName);
          

            return response;
        }
    }
}



