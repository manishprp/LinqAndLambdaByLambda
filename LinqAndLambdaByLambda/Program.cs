using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqAndLambda
{
    public class activitySetOneByLambda
    {
        List<string> cities = new List<string>
        {
            "Mumbai",
            "Delhi",
            "Ahmedabad",
            "Surat",
            "Valsad",
            "Varanasi"  ,
            "Chennai",
            "Bhopal",
            "Darjeeling",
        };

        public static void Main(string[] args)
        {
            activitySetOneByLambda activitySetOne = new activitySetOneByLambda();

            // For Descending Order
            Console.WriteLine("For Descending Order");
            Console.WriteLine();
            IEnumerable<string> citiesDescendingOrder = activitySetOne.descendingOrder(activitySetOne);
            activitySetOne.displayTheResult(citiesDescendingOrder);


            //For Ascending Order
            Console.WriteLine();
            Console.WriteLine("For Ascending Order");
            Console.WriteLine();
            IEnumerable<string> citiesAscendingOrder = activitySetOne.citiesAscendingOrder(activitySetOne);
            activitySetOne.displayTheResult(citiesAscendingOrder);

            //For Descending by length
            Console.WriteLine();
            Console.WriteLine("For Descending by length");
            Console.WriteLine();
            IEnumerable<string> citiesDescendingOrderByLength = activitySetOne.descendingByLength(activitySetOne);
            activitySetOne.displayTheResult(citiesDescendingOrderByLength);


            //For Descending by length
            Console.WriteLine();
            Console.WriteLine("For Ascending by length");
            Console.WriteLine();
            IEnumerable<string> citiesAscendingOrderByLength = activitySetOne.ascendingByLength(activitySetOne);
            activitySetOne.displayTheResult(citiesAscendingOrderByLength);

            //Get cities names starts with V and D letter.

            Console.WriteLine();
            Console.WriteLine("Get cities names starts with V and D letter.");
            Console.WriteLine();
            IEnumerable<string> citiesWithAandD = activitySetOne.citiesWithVandDMethod(activitySetOne);
            activitySetOne.displayTheResult(citiesWithAandD);


            // Get count of city names starts with A letter.
            Console.WriteLine();
            Console.WriteLine("Count city of Start with A .");
            Console.WriteLine();
            IEnumerable<string> countOfStartWithA = activitySetOne.countOfStartWithAMethod(activitySetOne);
            Console.WriteLine("Count of Cities with A is " + countOfStartWithA.Count());

            // Group ordered city names by its first letter

            Console.WriteLine();
            Console.WriteLine("Group cities by first letter");
            Console.WriteLine();
            activitySetOne.groupByFirstLetterMethod(activitySetOne);


        }

        // group by first letter

        public void groupByFirstLetterMethod(activitySetOneByLambda activitySetOne)
        {
            var groupByFirstLetter = activitySetOne.cities.GroupBy(c => c[0]);
            

            foreach (var currentLetterGroup in groupByFirstLetter)
            {
                Console.WriteLine("\tWords that begin with '{0}':", currentLetterGroup.Key);
                foreach (var name in currentLetterGroup)
                {
                    Console.WriteLine("\t{0}", name);
                }
            }
        }
        public IEnumerable<string> countOfStartWithAMethod(activitySetOneByLambda activitySetOne)
        {
            var countOfStartWithA = activitySetOne.cities.Where(c => c[0] == 'A');          
            return countOfStartWithA;
        }

        public IEnumerable<string> citiesWithVandDMethod(activitySetOneByLambda activitySetOne)
        {
            var citiesWithVandD = activitySetOne.cities.Where(c => c[0] == 'V' || c[0] == 'D');      
            return citiesWithVandD;
        }

        public IEnumerable<string> descendingByLength(activitySetOneByLambda activitySetOne)
        {
            var descendingByLength = activitySetOne.cities.OrderByDescending(c => c.Length);

            return descendingByLength;
        }

        public IEnumerable<string> ascendingByLength(activitySetOneByLambda activitySetOne)
        {
            var ascendingByLength =
           activitySetOne.cities.OrderBy(c => c.Length);
             
            return ascendingByLength;
        }

        public IEnumerable<string> citiesAscendingOrder(activitySetOneByLambda activitySetOne)
        {
            var citiesAscendingOrder =
             activitySetOne.cities.OrderBy(c => c);
            return citiesAscendingOrder;
        }
        public IEnumerable<string> descendingOrder(activitySetOneByLambda activitySetOne)
        {
            var citiesDescendingOrder = activitySetOne.cities.OrderByDescending(c=>c);

            return citiesDescendingOrder;
        }
        public void displayTheResult(IEnumerable<string> resultIn)
        {
            foreach (var c in resultIn)
            {
                Console.WriteLine(c);
            }
        }
    }
}
