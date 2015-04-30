using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NTestApi.Controllers
{
    [RoutePrefix("api/v1")]
    public class V1Controller : ApiController
    {

        // GET: api/FRED/GDP
        //		Url	"http://localhost:49832/api/v1/datasets/fred/gdp.json?auth_token=asdfa"	string


        [Route("")]
        [Route("datasets/{param1}/{param2}.{param3}/{auth_token?}")]
        public FRED_GDP Get(string param1, string param2, string param3, string auth_token)
        {
            var response = new FRED_GDP
            {
                id = 120140,
                source_name = "Federal Reserve Economic Data",
                source_code = "FRED",
                code = "GDP",
                name = "Gross Domestic Product, 1 Decimal",
                urlize_name = "Gross-Domestic-Product-1-Decimal",
                display_url = "http://research.stlouisfed.org/fred2/data/GDP.txt",
                description =
                    "Units: Billions of Dollars\nSeasonal Adjustment: Seasonally Adjusted Annual Rate\nNotes: A Guide to the National Income and Product Accounts of the United States (NIPA) - (http://www.bea.gov/national/pdf/nipaguid.pdf)",
                updated_at = DateTime.Now,
                frequency = "quarterly",
                from_date = "1947-01-01",
                to_date = "2015-01-01",
                column_names = new[] {"Date", "Value"},
                _private = false,
                type = null,
                premium = false,
                data = new DataDateValue().GetObjects()
            };

            return response;
        }
    }
}



