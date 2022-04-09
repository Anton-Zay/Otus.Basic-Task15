using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            var Venera_1 = new
            {
                Name = "Венера",
                SerialNumber = 1,
                EquatorLength = 38025,
                //PrevPlanets = null,
            };

            var Earth = new
            {
                Name = "Земля",
                SerialNumber = 2,
                EquatorLength = 40075,
                PrevPlanets = Venera_1,
            };

            var Mars = new
            {
                Name = "Марс",
                SerialNumber = 3,
                EquatorLength = 21344,
                PrevPlanets = Earth,
            };

            var Venera_2 = new
            {
                Name = "Венера",
                SerialNumber = 1,
                EquatorLength = 38025,
                PrevPlanets = Mars,
            };

            Console.WriteLine($"Информация о планете:\n{Venera_1}\nЭквивалентность Венере:\n{(Venera_1.Equals(Venera_1) ?"Эквивалентна": "Не эквивалентна")}\n--------");
            Console.WriteLine($"Информация о планете:\n{Earth}\nЭквивалентность Венере:\n{(Earth.Equals(Venera_1) ?"Эквивалентна": "Не эквивалентна")}\n--------");
            Console.WriteLine($"Информация о планете:\n{Mars}\nЭквивалентность Венере:\n{(Mars.Equals(Venera_1) ?"Эквивалентна": "Не эквивалентна")}\n--------");
            Console.WriteLine($"Информация о планете:\n{Venera_2}\nЭквивалентность Венере:\n{(Venera_2.Equals(Venera_1) ?"Эквивалентна": "Не эквивалентна")}\n--------");

            Console.WriteLine("-------------------------------------------------------");
            //Task 2
            PlanetCatalog planetCatalog = new PlanetCatalog();

            var (SerialNumberFromSunEarth, EquatorLengthEarth, messageEarth) = planetCatalog.GetPlanet("Земля");
            var (SerialNumberFromSunLim, EquatorLengthLim, messageLim) = planetCatalog.GetPlanet("Лимония");
            var (SerialNumberFromSunMars, EquatorLengthMars, messageMars) = planetCatalog.GetPlanet("Марс");
            var (SerialNumberFromSunMars1, EquatorLengthMars1, messageMars1) = planetCatalog.GetPlanet("Марс");

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