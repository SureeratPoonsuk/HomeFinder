using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeFinder.Data
{
    public class MunicipalityService
    {
        private List<Municipality> municipalities = new List<Municipality>
        {
            new Municipality
            {
                Id = 1,
                 Name = "Jönköping"
            },
            new Municipality
            {
                Id = 2,
                 Name = "Bankeryd"
            },
            new Municipality
            {
                Id = 3,
                 Name = "Nässjö"
            }
        };

        public List<Municipality> GetAllMunicipalities()
        {
            return municipalities;
        }

        public Municipality GetMunicipality(int id)
        {
            return municipalities.Where( x => x.Id == id ).First();          

        }
    }
}
