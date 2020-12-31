using System;

namespace CalcDist
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = CalculateDistance(40.395128648978776, 49.90370819076838, 
                40.414172275568517, 49.97251755698636);

            Console.WriteLine(d);
        }

        private static double CalculateDistance(double lat1, double long1, 
            double lat2, double long2)
        {
            double radius = 6371 * 1000;

            var lat1Rad = (Math.PI / 180) * lat1;
            var lat2Rad = (Math.PI / 180) * lat2;

            var dLat = (Math.PI / 180) * (lat2 - lat1);
            var dLong = (Math.PI / 180) * (long2 - long1);

            var a = Math.Pow(Math.Sin(dLat / 2), 2) +
                    Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                    Math.Pow(Math.Sin(dLong / 2), 2);
            
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            var distance = radius * c;

            return distance;
        }
    }

    // C# program to implement
// Luhn algorithm
    class GFG {
        
    // Returns true if given 
    // card number is valid
        static bool checkLuhn(String cardNo)
        {
            int nDigits = cardNo.Length;

            int nSum = 0;
            bool isSecond = false;
            for (int i = nDigits - 1; i >= 0; i--) 
            {

                int d = cardNo[i] - '0';

                if (isSecond == true)
                    d = d * 2;

                // We add two digits to handle
                // cases that make two digits 
                // after doubling
                nSum += d / 10;
                nSum += d % 10;

                isSecond = !isSecond;
            }
            return (nSum % 10 == 0);
        }

        // Driver code
        static public void Main()
        {
            String cardNo = "79927398713";
            if (checkLuhn(cardNo))
                Console.WriteLine("This is a valid card");
            else
                Console.WriteLine("This is not a valid card");
        
        }
    }

}
