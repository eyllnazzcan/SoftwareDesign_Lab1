using System.IO;

string path = "apartment_buildings_2019.csv";

string[] lines = System.IO.File.ReadAllLines(path);
int counter = 0;
foreach(string line in lines)
{
    counter++;
}

Console.WriteLine(counter-1);

