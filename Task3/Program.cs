using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 3
            PlanetCatalog planetCatalog = new PlanetCatalog();

            var (SerialNumberFromSunEarth, EquatorLengthEarth, messageEarth) = planetCatalog.GetPlanet("Земля", planetCatalog.PlanetValidatorMethod);
            var (SerialNumberFromSunLim, EquatorLengthLim, messageLim) = planetCatalog.GetPlanet("Лимония", planetCatalog.PlanetValidatorMethod);
            var (SerialNumberFromSunMars, EquatorLengthMars, messageMars) = planetCatalog.GetPlanet("Марс", planetCatalog.PlanetValidatorMethod);
            var (SerialNumberFromSunMars1, EquatorLengthMars1, messageMars1) = planetCatalog.GetPlanet("Марс", planetCatalog.PlanetValidatorMethod);

            if (string.IsNullOrEmpty(messageEarth))
            {
                Console.WriteLine(
                    $"Планета Земля\nПорядковый номер от солнца: {SerialNumberFromSunEarth}\nДлина экватора: {EquatorLengthEarth}\n----------");
            }
            else
            {
                Console.WriteLine($"Планета Земля\n{messageEarth}\n----------");
            }

            if (string.IsNullOrEmpty(messageLim))
            {
                Console.WriteLine(
                    $"Планета Лимония\nПорядковый номер от солнца: {SerialNumberFromSunLim}\nДлина экватора: {EquatorLengthLim}\n----------");
            }
            else
            {
                Console.WriteLine($"Планета Лимония\n{messageLim}\n----------");
            }

            if (string.IsNullOrEmpty(messageMars))
            {
                Console.WriteLine(
                    $"Планета Марс\nПорядковый номер от солнца: {SerialNumberFromSunMars}\nДлина экватора: {EquatorLengthMars}\n----------");
            }
            else
            {
                Console.WriteLine($"Планета Марс\n{messageMars}\n----------");
            }

            if (string.IsNullOrEmpty(messageMars1))
            {
                Console.WriteLine(
                    $"Планета Марс\nПорядковый номер от солнца: {SerialNumberFromSunMars1}\nДлина экватора: {EquatorLengthMars1}\n----------");
            }
            else
            {
                Console.WriteLine($"Планета Марс\n{messageMars1}\n----------");
            }
        }
    }
}
