using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskOpgave.Tests
{
    [TestClass()]
    public class TrophyRepositoryTests

    {
        private TrophyRepository repository = new();
        [TestInitialize]
        public void Initialize()
        {
            // Initialiser repository med testdata

            repository.Add(new TrophyRepository { Competition = "OL France", Year = 2024 });
            repository.Add(new Trophy() { Competition = "Champions Leageu", Year = 2023 });
            repository.Add(new Trophy() { Competition = "SportCarsRace", Year = 2022 });
            repository.Add(new Trophy() { Competition = "Ski racing norge", Year = 2021 });
            repository.Add(new Trophy() { Competition = "Marathon Scandanavia", Year = 2020 });

        }



        [TestMethod()]
        public void GetByIdTest()
        {
            // Hent trofæer baseret på deres ID

            Trophy trophy1 = repository.GetById(1);
            Trophy trophy5 = repository.GetById(5);

            Assert.IsNotNull(trophy1);
            Assert.AreEqual("OL France", trophy1.Competition);

            Assert.IsNotNull(trophy5);
            Assert.AreEqual("Marathon Scandanavia", trophy5.Competition);




        }

        [TestMethod()]
        public void GetTest()
        {
            // Hent alle trofæer

            IEnumerable<Trophy> trophies = repository.Get();
            // Kontroller at trofælisten ikke er null

            Assert.IsNotNull(trophies);

            List<Trophy> tropiesList = new List<Trophy>(trophies);

            Assert.AreEqual(5, tropiesList.Count); // Der skal være 5 trofæer til at starte med


        }
        [TestMethod]
        public void RemoveTest()
        {

            Trophy removedTrophy = repository.Remove(1);
            IEnumerable<Trophy> trophies = repository.Get();
            List<Trophy> tropiesList = new List<Trophy>(trophies);


            Assert.IsNotNull(removedTrophy);
            Assert.AreEqual(4, tropiesList.Count);
            Assert.IsNull(repository.GetById(1));
        }

        [TestMethod]

        public void UpdateTest()
        {
            Trophy updatedTrophy = new Trophy { Competition = "Updated Competition", Year = 2019 };
            Trophy result = repository.Update(1, updatedTrophy);
            Assert.IsNotNull(result);
            Assert.AreEqual("Updated Competition", result.Competition);
            Assert.AreEqual(2024, result.Year);

        }
    }
}
    
