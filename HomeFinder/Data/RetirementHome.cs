using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeFinder.Data
{
    public class RetirementHome
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public int MunicipalityId { get; set; }
        public string Municipality { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
