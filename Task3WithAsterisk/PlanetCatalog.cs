using System.Collections.Generic;

namespace Task3WithAsterisk
{
    public class PlanetCatalog
    {

        List<Planet> planetCatalog = new List<Planet>();

        public PlanetCatalog()
        {
            planetCatalog.Add(new Planet("Венера", 2, 38025, null));
            planetCatalog.Add(new Planet("Земля", 3, 40075, planetCatalog[0]));
            planetCatalog.Add(new Planet("Марс", 4, 21344, planetCatalog[1]));
        }

        public (int SerialNumberFromSun, int EquatorLength, string message) GetPlanet(string PlanetName,
            PlanetValidator planetValidator, LimoniyaValidator limoniyaValidator)
        {
            var result = (SerialNumberFromSun: 0, EquatorLength: 0, message: "");

            //result.message = planetValidator();

            foreach (var planet in planetCatalog)
            {
                if (planet.Name.Equals(PlanetName)) 
                {
                    result.SerialNumberFromSun = planet.SerialNumberFromSun;
                    result.EquatorLength = planet.EquatorLength;
                    //return result;
                }
            }

            if (result.SerialNumberFromSun == 0)
            {
                result.message = "Не удалось найти планету";
                //return result;
            }

            if (PlanetName.Equals("Лимония"))
            {
                result.message = limoniyaValidator("Лимония");
               return result;
            }

            result.message = planetValidator();

            return result;
        }

        public delegate string PlanetValidator();

        public delegate string LimoniyaValidator(string Name);
    }
}