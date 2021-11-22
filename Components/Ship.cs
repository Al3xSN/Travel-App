namespace TravelApp
{
    public class Ship
    {
        public Ship(string name, string captainName, int passagersCount)
        {
            Name = name;
            CaptainName = captainName;
            PassagersCount = passagersCount;
        }

        public string Name { get; private set; }

        public string CaptainName { get; private set; }

        public int PassagersCount { get; private set; }
    }
}
