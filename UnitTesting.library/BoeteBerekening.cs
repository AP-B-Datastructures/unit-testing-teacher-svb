using System;

namespace UnitTesting.library
{
    public class BoeteBerekening
    {
        /// <summary>
        /// Berekent de snelheidsboete op basis van de snelheid, het snelheidslimiet en of de bestuurder zich in een schoolzone bevindt.
        /// De boete is als volgt:
        /// - Tot en met 9 km/h te snel: boete van €50.
        /// - Tussen 10 km/h en 19 km/h te snel: boete van €100.
        /// - 20 km/h (of meer) te snel: boete van €200.
        /// - In een schoolzone geldt een extra toeslag van €50.
        /// </summary>
        /// <param name="speed"></param>
        /// <param name="speedLimit"></param>
        /// <param name="inSchoolZone"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int BerekenBoete(int speed, int speedLimit, bool inSchoolZone)
        {
            throw new NotImplementedException();
        }
    }
}
