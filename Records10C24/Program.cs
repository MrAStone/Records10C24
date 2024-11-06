namespace Records10C24
{
    internal class Program
    {
        struct Town
        {
            public string townName;
            public int population;
            public double area;
            public string county;

            public Town(string tName,int tPop,double tArea,string tCounty)
            {
                townName = tName;
                population = tPop;
                area = tArea;
                county = tCounty;
            }
        }
        static void Main(string[] args)
        {
            Town myTown = new Town("Heckmondwike", 12, 12000, "W Yorks");
           // Console.WriteLine(myTown.townName);
            myTown.population = 13;
            Town[] towns = new Town[5];
            towns[0] = myTown;
            towns[1] = new Town("Batley", 42, 3, "W Yorks");
           // Console.WriteLine(towns[1].population);
            towns[2] = new Town("Birmingham", 1234, 22, "W Midlands");
            towns[3] = new Town("Doncaster", 6516, 1141, "S Yorks");
            towns[4] = new Town("Glasgow", 11356, 11231, "Lanarkshire");
            double avgPop = 0;
            double totalArea = 0;
            for(int i = 0;i<towns.Length;i++)
            {
                avgPop += towns[i].population;
                totalArea += towns[i].area;
                if (towns[i].county =="W Yorks")
                {
                    Console.WriteLine(towns[i].townName + " is in West Yorkshire");
                }
            }
            avgPop /= 5;
            Console.WriteLine($"The average population is {avgPop}. The total area is {totalArea}");

        }
    }
}
