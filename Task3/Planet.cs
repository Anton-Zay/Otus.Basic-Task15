namespace Task3
{
    public class Planet
    {
        public string Name { get; }
        public int SerialNumberFromSun { get; }
        public int EquatorLength { get; }

        public Planet PrevPlanet { get; }

        public Planet(string name, int serialNumberFromSun, int equatorLength, Planet prevPlanet)
        {
            this.Name = name;
            this.SerialNumberFromSun = serialNumberFromSun;
            this.EquatorLength = equatorLength;
            this.PrevPlanet = prevPlanet;
        }
    }
}