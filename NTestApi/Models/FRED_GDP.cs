using System;

namespace NTestApi.Controllers
{
    public class FRED_GDP
    {
        public Errors errors { get; set; }
        public int id { get; set; }
        public string source_name { get; set; }
        public string source_code { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string urlize_name { get; set; }
        public string display_url { get; set; }
        public string description { get; set; }
        public DateTime updated_at { get; set; }
        public string frequency { get; set; }
        public string from_date { get; set; }
        public string to_date { get; set; }
        public string[] column_names { get; set; }
        public bool _private { get; set; }
        public object type { get; set; }
        public bool premium { get; set; }
        public object[][] data { get; set; }
    }

    public class Errors
    {
    }

    public class DateValue
    {
        public string Date { get; set; }
        public Double Value { get; set; }
    }


    public class DataDateValue
    {
        public object[][] GetObjects()
        {
            var thisList = new[]
            {
                new object[] {"2015-01-01", 17710},
                new object[] {"2014-10-01", 17703.7},
                new object[] {"2014-07-01", 17599.8},
                new object[] {"2014-04-01", 17328.2},
                new object[] {"2014-01-01", 17044},
                new object[] {"2013-10-01", 17078.3},
                new object[] {"2013-07-01", 16872.3},
                new object[] {"2013-04-01", 16619.2},
                new object[] {"2013-01-01", 16502.4},
                new object[] {"2012-10-01", 16332.5},
                new object[] {"2012-07-01", 16268.9},
                new object[] {"2012-04-01", 16094.7},
                new object[] {"2012-01-01", 15956.5},
                new object[] {"2011-10-01", 15785.3},
                new object[] {"2011-07-01", 15587.1},
                new object[] {"2011-04-01", 15460.9},
                new object[] {"2011-01-01", 15238.4},
                new object[] {"2010-10-01", 15230.2},
                new object[] {"2010-07-01", 15057.7},
                new object[] {"2010-04-01", 14888.6},
                new object[] {"2010-01-01", 14681.1},
                new object[] {"2009-10-01", 14566.5},
                new object[] {"2009-07-01", 14384.1},
                new object[] {"2009-04-01", 14340.4},
                new object[] {"2009-01-01", 14383.9},
                new object[] {"2008-10-01", 14549.9},
                new object[] {"2008-07-01", 14843},
                new object[] {"2008-04-01", 14813},
                new object[] {"2008-01-01", 14668.4},
                new object[] {"2007-10-01", 14685.3},
                new object[] {"2007-07-01", 14569.7},
                new object[] {"2007-04-01", 14422.3},
                new object[] {"2007-01-01", 14233.2},
                new object[] {"2006-10-01", 14066.4},
                new object[] {"2006-07-01", 13908.5},
                new object[] {"2006-04-01", 13799.8},
                new object[] {"2006-01-01", 13648.9},
                new object[] {"2005-10-01", 13381.6},
                new object[] {"2005-07-01", 13205.4},
                new object[] {"2005-04-01", 12974.1},
                new object[] {"2005-01-01", 12813.7},
                new object[] {"2004-10-01", 12562.2},
                new object[] {"2004-07-01", 12367.7},
                new object[] {"2004-04-01", 12181.4},
                new object[] {"2004-01-01", 11988.4},
                new object[] {"2003-10-01", 11816.8},
                new object[] {"2003-07-01", 11625.1},
                new object[] {"2003-04-01", 11370.7},
                new object[] {"2003-01-01", 11230.1},
                new object[] {"2002-10-01", 11103.8},
                new object[] {"2002-07-01", 11037.1},
                new object[] {"2002-04-01", 10934.8},
                new object[] {"2002-01-01", 10834.4},
                new object[] {"2001-10-01", 10701.3},
                new object[] {"2001-07-01", 10639.5},
                new object[] {"2001-04-01", 10638.4},
                new object[] {"2001-01-01", 10508.1},
                new object[] {"2000-10-01", 10472.3},
                new object[] {"2000-07-01", 10357.4},
                new object[] {"2000-04-01", 10278.3},
                new object[] {"2000-01-01", 10031},
                new object[] {"1999-10-01", 9926.1},
                new object[] {"1999-07-01", 9712.3},
                new object[] {"1999-04-01", 9557},
                new object[] {"1999-01-01", 9447.1},
                new object[] {"1998-10-01", 9325.7},
                new object[] {"1998-07-01", 9146.5},
                new object[] {"1998-04-01", 8994.7},
                new object[] {"1998-01-01", 8889.7},
                new object[] {"1997-10-01", 8788.3},
                new object[] {"1997-07-01", 8691.8},
                new object[] {"1997-04-01", 8551.9},
                new object[] {"1997-01-01", 8402.1},
                new object[] {"1996-10-01", 8287.1},
                new object[] {"1996-07-01", 8159},
                new object[] {"1996-04-01", 8061.5},
                new object[] {"1996-01-01", 7893.1},
                new object[] {"1995-10-01", 7799.5},
                new object[] {"1995-07-01", 7706.5},
                new object[] {"1995-04-01", 7604.9},
                new object[] {"1995-01-01", 7545.3},
                new object[] {"1994-10-01", 7476.7},
                new object[] {"1994-07-01", 7352.3},
                new object[] {"1994-04-01", 7269.8},
                new object[] {"1994-01-01", 7136.3},
                new object[] {"1993-10-01", 7032.8},
                new object[] {"1993-07-01", 6904.2},
                new object[] {"1993-04-01", 6829.6},
                new object[] {"1993-01-01", 6748.2},
                new object[] {"1992-10-01", 6697.6},
                new object[] {"1992-07-01", 6586.5},
                new object[] {"1992-04-01", 6492.3},
                new object[] {"1992-01-01", 6380.8},
                new object[] {"1991-10-01", 6279.3},
                new object[] {"1991-07-01", 6218.4},
                new object[] {"1991-04-01", 6143.6},
                new object[] {"1991-01-01", 6054.9},
                new object[] {"1990-10-01", 6023.3},
                new object[] {"1990-07-01", 6029.5},
                new object[] {"1990-04-01", 5974.7},
                new object[] {"1990-01-01", 5890.8},
                new object[] {"1989-10-01", 5763.4},
                new object[] {"1989-07-01", 5711.6},
                new object[] {"1989-04-01", 5628.4},
                new object[] {"1989-01-01", 5527.4},
                new object[] {"1988-10-01", 5412.7},
                new object[] {"1988-07-01", 5299.5},
                new object[] {"1988-04-01", 5207.7},
                new object[] {"1988-01-01", 5090.6},
                new object[] {"1987-10-01", 5022.7},
                new object[] {"1987-07-01", 4900.5},
                new object[] {"1987-04-01", 4821.5},
                new object[] {"1987-01-01", 4736.2},
                new object[] {"1986-10-01", 4669.4},
                new object[] {"1986-07-01", 4619.6},
                new object[] {"1986-04-01", 4555.2},
                new object[] {"1986-01-01", 4516.3},
                new object[] {"1985-10-01", 4453.1},
                new object[] {"1985-07-01", 4394.6},
                new object[] {"1985-04-01", 4302.3},
                new object[] {"1985-01-01", 4237},
                new object[] {"1984-10-01", 4147.6},
                new object[] {"1984-07-01", 4087.4},
                new object[] {"1984-04-01", 4015},
                new object[] {"1984-01-01", 3912.8},
                new object[] {"1983-10-01", 3796.1},
                new object[] {"1983-07-01", 3692.3},
                new object[] {"1983-04-01", 3583.8},
                new object[] {"1983-01-01", 3480.3},
                new object[] {"1982-10-01", 3407.8},
                new object[] {"1982-07-01", 3367.1},
                new object[] {"1982-04-01", 3331.3},
                new object[] {"1982-01-01", 3273.8},
                new object[] {"1981-10-01", 3283.5},
                new object[] {"1981-07-01", 3261.2},
                new object[] {"1981-04-01", 3167.3},
                new object[] {"1981-01-01", 3131.8},
                new object[] {"1980-10-01", 2993.5},
                new object[] {"1980-07-01", 2860},
                new object[] {"1980-04-01", 2799.9},
                new object[] {"1980-01-01", 2796.5},
                new object[] {"1979-10-01", 2730.7},
                new object[] {"1979-07-01", 2670.4},
                new object[] {"1979-04-01", 2595.9},
                new object[] {"1979-01-01", 2531.6},
                new object[] {"1978-10-01", 2482.2},
                new object[] {"1978-07-01", 2398.9},
                new object[] {"1978-04-01", 2336.6},
                new object[] {"1978-01-01", 2208.7},
                new object[] {"1977-10-01", 2168.7},
                new object[] {"1977-07-01", 2122.4},
                new object[] {"1977-04-01", 2060.2},
                new object[] {"1977-01-01", 1992.5},
                new object[] {"1976-10-01", 1938.4},
                new object[] {"1976-07-01", 1890.5},
                new object[] {"1976-04-01", 1856.9},
                new object[] {"1976-01-01", 1824.5},
                new object[] {"1975-10-01", 1765.9},
                new object[] {"1975-07-01", 1713.8},
                new object[] {"1975-04-01", 1656.4},
                new object[] {"1975-01-01", 1619.6},
                new object[] {"1974-10-01", 1603},
                new object[] {"1974-07-01", 1563.4},
                new object[] {"1974-04-01", 1534.2},
                new object[] {"1974-01-01", 1494.7},
                new object[] {"1973-10-01", 1479.1},
                new object[] {"1973-07-01", 1436.8},
                new object[] {"1973-04-01", 1417.6},
                new object[] {"1973-01-01", 1380.7},
                new object[] {"1972-10-01", 1332},
                new object[] {"1972-07-01", 1293.8},
                new object[] {"1972-04-01", 1270.1},
                new object[] {"1972-01-01", 1233.8},
                new object[] {"1971-10-01", 1193.6},
                new object[] {"1971-07-01", 1180.3},
                new object[] {"1971-04-01", 1159.4},
                new object[] {"1971-01-01", 1137.8},
                new object[] {"1970-10-01", 1091.5},
                new object[] {"1970-07-01", 1088.5},
                new object[] {"1970-04-01", 1070.1},
                new object[] {"1970-01-01", 1053.5},
                new object[] {"1969-10-01", 1040.7},
                new object[] {"1969-07-01", 1032},
                new object[] {"1969-04-01", 1011.4},
                new object[] {"1969-01-01", 995.4},
                new object[] {"1968-10-01", 970.1},
                new object[] {"1968-07-01", 952.3},
                new object[] {"1968-04-01", 936.3},
                new object[] {"1968-01-01", 911.1},
                new object[] {"1967-10-01", 883.2},
                new object[] {"1967-07-01", 866.6},
                new object[] {"1967-04-01", 851.1},
                new object[] {"1967-01-01", 846},
                new object[] {"1966-10-01", 834.9},
                new object[] {"1966-07-01", 820.8},
                new object[] {"1966-04-01", 807.2},
                new object[] {"1966-01-01", 797.3},
                new object[] {"1965-10-01", 773.1},
                new object[] {"1965-07-01", 750.2},
                new object[] {"1965-04-01", 732.4},
                new object[] {"1965-01-01", 719.2},
                new object[] {"1964-10-01", 698.4},
                new object[] {"1964-07-01", 692.8},
                new object[] {"1964-04-01", 680.8},
                new object[] {"1964-01-01", 671.1},
                new object[] {"1963-10-01", 654.8},
                new object[] {"1963-07-01", 645},
                new object[] {"1963-04-01", 631.8},
                new object[] {"1963-01-01", 622.7},
                new object[] {"1962-10-01", 613.1},
                new object[] {"1962-07-01", 609.6},
                new object[] {"1962-04-01", 602.6},
                new object[] {"1962-01-01", 595.2},
                new object[] {"1961-10-01", 581.6},
                new object[] {"1961-07-01", 568.2},
                new object[] {"1961-04-01", 557.4},
                new object[] {"1961-01-01", 545.9},
                new object[] {"1960-10-01", 541.1},
                new object[] {"1960-07-01", 546},
                new object[] {"1960-04-01", 542.7},
                new object[] {"1960-01-01", 543.3},
                new object[] {"1959-10-01", 529.3},
                new object[] {"1959-07-01", 525.2},
                new object[] {"1959-04-01", 524.2},
                new object[] {"1959-01-01", 511.1},
                new object[] {"1958-10-01", 500.4},
                new object[] {"1958-07-01", 486.7},
                new object[] {"1958-04-01", 472.8},
                new object[] {"1958-01-01", 468.4},
                new object[] {"1957-10-01", 475.7},
                new object[] {"1957-07-01", 480.3},
                new object[] {"1957-04-01", 472.8},
                new object[] {"1957-01-01", 470.6},
                new object[] {"1956-10-01", 461.3},
                new object[] {"1956-07-01", 452},
                new object[] {"1956-04-01", 446.8},
                new object[] {"1956-01-01", 440.5},
                new object[] {"1955-10-01", 437.8},
                new object[] {"1955-07-01", 430.9},
                new object[] {"1955-04-01", 422.2},
                new object[] {"1955-01-01", 413.8},
                new object[] {"1954-10-01", 400.3},
                new object[] {"1954-07-01", 391.6},
                new object[] {"1954-04-01", 386.7},
                new object[] {"1954-01-01", 385.9},
                new object[] {"1953-10-01", 386.5},
                new object[] {"1953-07-01", 391.7},
                new object[] {"1953-04-01", 392.3},
                new object[] {"1953-01-01", 388.5},
                new object[] {"1952-10-01", 381.2},
                new object[] {"1952-07-01", 368.1},
                new object[] {"1952-04-01", 361.4},
                new object[] {"1952-01-01", 360.2},
                new object[] {"1951-10-01", 356.6},
                new object[] {"1951-07-01", 351.8},
                new object[] {"1951-04-01", 344.5},
                new object[] {"1951-01-01", 336.4},
                new object[] {"1950-10-01", 320.3},
                new object[] {"1950-07-01", 308.5},
                new object[] {"1950-04-01", 290.7},
                new object[] {"1950-01-01", 281.2},
                new object[] {"1949-10-01", 271},
                new object[] {"1949-07-01", 273.3},
                new object[] {"1949-04-01", 271.7},
                new object[] {"1949-01-01", 275.4},
                new object[] {"1948-10-01", 280.7},
                new object[] {"1948-07-01", 279.5},
                new object[] {"1948-04-01", 272.9},
                new object[] {"1948-01-01", 266.2},
                new object[] {"1947-10-01", 260.3},
                new object[] {"1947-07-01", 250.1},
                new object[] {"1947-04-01", 246.3},
                new object[] {"1947-01-01", 243.1}
            };

            return thisList;
        }
    }
}

public class Rootobject
{
    public Errors errors { get; set; }
    public int id { get; set; }
    public string source_name { get; set; }
    public string source_code { get; set; }
    public string code { get; set; }
    public string name { get; set; }
    public string urlize_name { get; set; }
    public string display_url { get; set; }
    public string description { get; set; }
    public DateTime updated_at { get; set; }
    public string frequency { get; set; }
    public string from_date { get; set; }
    public string to_date { get; set; }
    public string[] column_names { get; set; }
    public bool _private { get; set; }
    public object type { get; set; }
    public bool premium { get; set; }
    public object[][] data { get; set; }
}

public class Errors
{
}