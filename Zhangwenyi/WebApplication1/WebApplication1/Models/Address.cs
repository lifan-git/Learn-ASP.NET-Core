using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Address
    {
        public string Street { set; get; }
        public string City { set; get; }
        public string State { set; get; }
        public string PostalCode { set; get; }

        public string Name { set; get; }
    }
}
