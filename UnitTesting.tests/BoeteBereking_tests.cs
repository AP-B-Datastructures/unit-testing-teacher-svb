using System;
using UnitTesting.library;

namespace UnitTesting.tests
{
    [TestClass]
    public class BoeteBereking_tests
    {
        [DataTestMethod]
        [DataRow(0, 100)]
        [DataRow(100, 100)]
        [DataRow(20, 30)]
        [DataRow(79, 80)]
        [DataRow(-10, 80)]
        public void Test_GeenBoeteAlsJeDeSnelheidslimietNietOverschrijdt(int snelheid, int limiet)
        {
            // Arrange
            bool schoolZone = false;

            // Act
            int boete = BoeteBerekening.BerekenBoete(snelheid, limiet, schoolZone);

            // Assert
            Assert.AreEqual(0, boete);
        }

        [TestMethod]
        public void Test_NietInSchoolzone_200BoeteAlsJe20KPUTeSnelRijdt()
        {
            // Arrange
            int snelheid = 120;
            int limiet = 100;
            bool schoolZone = false;

            // Act
            int boete = BoeteBerekening.BerekenBoete(snelheid, limiet, schoolZone);

            // Assert
            Assert.AreEqual(200, boete);
        }

        [TestMethod]
        public void Test_NietInSchoolzone_50BoeteAlsJeMax9KPUTeSnelRijdt()
        {
            // Arrange
            int snelheid = 109;
            int limiet = 100;
            bool schoolZone = false;

            // Act
            int boete = BoeteBerekening.BerekenBoete(snelheid, limiet, schoolZone);

            // Assert
            Assert.AreEqual(50, boete);
        }
    }
}
