using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeFinder.Data
{
    public class ApartmentService
    {
        private List<Apartment> apartments = new List<Apartment>
        {
            new Apartment
            {
                Id = 1,
                RetirementHomeId = 1,
                Price = 5600,
                Description = "Jönköping äldreboende ligger nära Vätter, fint utsikt, det finns inne gården där alla kan sitta. Lägenhet är 1 rum och kök.",
                Size = 68,
                Images = new List<string>
                {
                    "/images/lgh1.png",
                    "/images/lgh2.png",
                    "/images/lgh3.png"
                }
                
            },
            new Apartment
            {
                Id = 2,
                RetirementHomeId = 2,
                Price = 3500,
                Description = "Solticke äldboende ligger i Bankeryd. Det är 6 avdelningar i sammalagt, 2 avdelningar är dementboende. Lägenhet är ett rum och kök. ",
                Size = 75,
                Images = new List<string>
                {
                    "/images/bankeryd.png",
                  "/images/rumbankeryd.png"
                }
            },
             new Apartment
            {
                Id = 3,
                RetirementHomeId = 3,
                Price = 5500,
                Description = "Ett fint äldreboende som bor mitti Centralen i Nässjö. Nära parken där man kan sitta och fika. Rumet är 1 rum och kök",
                Size = 85,
                Images = new List<string>
                {
                    "/images/n2.png",
                    "/images/n3.png",
                    "/images/n4.pgn",
                    "/images/n1.png"
                }
            },
             new Apartment
            {
                Id = 4,
                RetirementHomeId = 1,
                Price = 4400,
                Description = "Jönköping äldreboende ligger nära Vätter, fint utsikt, det finns inne gården där alla kan sitta. Lägenhet är 1 rum och kök.",
                Size = 78,
                Images = new List<string>
                {
                    "/images/lgh1.png",
                    "/images/lgh2.png",
                    "/images/lgh3.png"
                }

            },
        };

        public Apartment GetApartment(int id)
        {
            var apartment = apartments.Where(x => x.Id == id).First();

            var homeService = new RetirementHomeService();
            var retirementHome = homeService.GetRetirementHome(apartment.RetirementHomeId);
            apartment.RetirementHome = retirementHome;

            return apartment;
        }

        public List<Apartment> GetApartmentsByMunicipality(int municipalityId)
        {
            var homeService = new RetirementHomeService();
            var homes = homeService.GetRetirementHomesByMunicipality(municipalityId);

            var allApartments = new List<Apartment>();
            foreach (var home in homes)
            {
                var matches = apartments.Where(x => x.RetirementHomeId == home.Id).ToList();

                foreach (var match in matches)
                {
                    match.RetirementHome = home;
                }

                allApartments.AddRange(matches);
            }

            return allApartments;
        } 
    }
}
