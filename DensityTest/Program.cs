using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using DensityTest.DensityModels;

namespace DensityTest
{
    public class Program
    {
        public static List<Space> federalStreetSpaces = new List<Space>();
        public static DensityClient client = new DensityClient();

        static void Main(string[] args)
        {
            var listOfSpaces = client.GetSpacesList().Result;

            federalStreetSpaces = listOfSpaces.Where(x => x.ancestry.Contains(new Ancestry{name = "800 Federal Street"})).ToList();

            Timer t = new Timer(HandleTimerElapsed, null, 0, 5000);
            Console.ReadLine();
        }

        public static void HandleTimerElapsed(Object o)
        {
            ListOccupancyForSpace(federalStreetSpaces);
        }

        public static void ListOccupancyForSpace(List<Space> spaces)
        {
            foreach (var s in spaces)
            {
                var theCounts = client.GetCounts(s.id, DateTimeOffset.Now, DateTimeOffset.Now.AddMilliseconds(1)).Result;
                var currentCount = theCounts.First().count;
                Console.Write($"{s.name}: {currentCount}\n");
            }
            Console.WriteLine("\n");
        }
    }
}
