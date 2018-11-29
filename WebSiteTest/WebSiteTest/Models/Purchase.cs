using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteTest.Models
{
    public class Purchase
    {
        public int PuchaseId { get; set; }
        public int BookId { get; set; }
        public int Person { get; set; }
        public int Adress { get; set; }
        public DateTime Data { get; set; }



    }
}