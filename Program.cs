using System.IO;

namespace CSVFile
{
    class Program
    {
        public static void countByStreet()
        {
            string path = "apartment_buildings_2019.csv";

            var lines = System.IO.File.ReadAllLines(path);
            int counter = 0;

            foreach(var line in lines)
            {
                string[] values = line.Split(";"); // Split each value
                string street = values[1];

                int numb = 0;
                var isnumber = int.TryParse(street, out numb);

                if(isnumber==false) //check if the counter is in the "adresas" column
                {
                    counter++;
                }
                
            }

            Console.WriteLine("Building count by street: " + (counter-1));
        }

        public static void yearBuilt()
        {
            string path = "apartment_buildings_2019.csv";
            var lines = System.IO.File.ReadAllLines(path);
            int thisYear = 1960, max = 0, min = thisYear;
            double sum = 0;

            foreach(var line in lines)
            {    
                string[] values = line.Split(";"); // Split each value
                string year = values[10];
                var isnumber = int.TryParse(year, out thisYear);

                if(isnumber && thisYear != 0) // Makes sure that it is a number different to 0 
                {
                    min = Math.Min(min,thisYear);
                    max = Math.Max(max,thisYear);
                    sum = sum + thisYear;
                }
            }

            double avg = sum / (lines.Length - 1);
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Min construction year: " + min);
            Console.WriteLine("Max construction year: " + max);
            Console.WriteLine("Average construction year: " + ((int)avg));
        }



        public static void Main()
        {
            countByStreet();
            yearBuilt();

        }

    }
}

