using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mnxi_webapi.Models
{
    public class DoantaionParams
    {
        public DateTime FromDate { set; get; }
        public DateTime ToDate { set; get; }
        public string CategoryName { set; get; }
        public string ServiceName { set; get; }
        
    }
}