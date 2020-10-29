using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeFinder.Data
{
    public class Apartment
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public double Size { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        public int RetirementHomeId { get; set; }
        public RetirementHome RetirementHome { get; set; }
    }
}
