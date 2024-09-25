using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskOpgave.Tests
{
    [TestClass()]
    public class TrophyTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            Trophy trophy = new Trophy()
            {
                Id = 1,
                Competition = "Trofæer",
                Year = 1970
            };

            string result = trophy.ToString();

            Assert.AreEqual("Id: 1, Competition: Trofæer, Year: 1970", result);


        }

        [TestMethod()]
        public void ValidateComeptitionTest()
        {
            {

                Trophy trophy = new Trophy() { Competition = null };
                Assert.ThrowsException<ArgumentNullException>(() => trophy.ValidateCompetition());

                trophy.Competition = "Jo";
                Assert.ThrowsException<ArgumentOutOfRangeException>(() => trophy.ValidateCompetition());
            }

        }

        [TestMethod()]
        public void ValidateYearTest()
        {
            Trophy trophy = new Trophy() { Year = 1969 };
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => trophy.ValidateYear());

            trophy.Year = 2025;
            Assert.ThrowsException<ArgumentOutOfRangeException>( () => trophy.ValidateYear());

        }

        [TestMethod()]
        public void ValidateTest()
        {
            
        }
    }
}