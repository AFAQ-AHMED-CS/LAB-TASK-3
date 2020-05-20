using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LAB11_WEB_API.Models{
    public class CAR_CLASS{
        public int    CAR_ID    { get; set; }
        public string CAR_NAME  { get; set; }
        public int    CAR_MODEL { get; set; }
        public string CAR_COLOR { get; set; }
        public double CAR_PRICE { get; set; }
    }
}