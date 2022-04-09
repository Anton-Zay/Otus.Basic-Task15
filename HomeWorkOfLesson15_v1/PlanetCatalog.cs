using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;

namespace Task1
{
    public class PlanetCatalog
    {
        private int CounterGetPlanetCall;

        List<Planet> planetCatalog = new List<Planet>();

        public PlanetCatalog()
        {
            planetCatalog.Add(new Planet("Венера", 2, 38025, null));
            planetCatalog.Add(new Planet("Земля", 3, 40075, planetCatalog[0]));
            planetCatalog.Add(new Planet("Марс", 4, 21344, planetCatalog[1]));
        }

        public (int SerialNumberFromSun, int EquatorLength, string message) GetPlanet(string PlanetName)
        {
            var result = (SerialNumberFromSun: 0, EquatorLength: 0, message: "");

            CounterGetPlanetCall++;

            if (CounterGetPlanetCall == 3)
            {
                result.message = "Вы спрашиваете слишком часто";
                CounterGetPlanetCall = 0;
                return result;
            }

            foreach (var planet in planetCatalog)
            {
                if (planet.Name.Equals(PlanetName))
                {
                    result.SerialNumberFromSun = planet.SerialNumberFromSun;
                    result.EquatorLength = planet.EquatorLength;
                    return result;
                }
            }

            if (result.SerialNumberFromSun == 0)
            {
                result.message = "Не удалось найти планету";
                return result;
            }

            return result;
        }
    }
}