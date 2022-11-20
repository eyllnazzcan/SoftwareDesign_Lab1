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

        public static void Main()
        {
            countByStreet();
        }

    }
}

