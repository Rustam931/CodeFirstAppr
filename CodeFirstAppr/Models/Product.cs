using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CodeFirstAppr.Models;

namespace CodeFirstAppr.Models
{
    public class Product
    {
        
        public int Id { get; set; }

        public string PName { get; set; }

        public int CId { get; set; }

        public string CName { get; set; }
    }
}