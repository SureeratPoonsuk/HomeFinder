using System.Collections.Generic;
using System.Linq;

namespace HomeFinder.Data
{
    public class RetirementHomeService
    {
        private List<RetirementHome> Homes = new List<RetirementHome>
        {
            new RetirementHome
            {
                Id = 1,
                Name = "Solstickans äldreboende",
                Description = "Lägenhet ligger nära centralen",
                Adress = "Jönköpingsgata 2 63 635",
                Phone = "036 1010 1010",
                MunicipalityId = 1,
                Longitude = 14.1486075,
                Latitude = 57.7793551
            },
            new RetirementHome
            {
                Id = 2,
                Name = "Bankeryd äldreboende",
                Description = "Fint området, nära parken",
                Adress = "Dundresgatan 5 55598 Bankeryd",
                Phone = "036 111 111",
                MunicipalityId = 2,
                Longitude = 14.10696,
                Latitude = 57.8602063
            },
            new RetirementHome
            {
                Id = 3,
                Name = "Nässjö äldreboende",
                Description = "Ligger nära centralen, nära parken.",
                Adress = "Nässjösgatan 2 32356",
                Phone = "036 111 262",
                MunicipalityId = 3,
                Longitude = 14.6932977,
                Latitude =57.6528028
            }
        };

        public RetirementHome GetRetirementHome(int id)
        {
            var home = Homes.Where(x => x.Id == id).First();

            var municipalityService = new MunicipalityService();
            home.Municipality = municipalityService.GetMunicipality(home.MunicipalityId).Name;

            return home;
        }

        public List<RetirementHome> GetRetirementHomesByMunicipality(int municipalityId)
        {
            var municipalityService = new MunicipalityService();
            var municipality = municipalityService.GetMunicipality(municipalityId);

            var homes = Homes.Where(x => x.MunicipalityId == municipalityId).ToList();

            foreach (var home in homes)
            {
                home.Municipality = municipality.Name;
            }

            return homes;
        }
    }
}
