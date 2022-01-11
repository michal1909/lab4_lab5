// See https://aka.ms/new-console-template for more information
//Zadanie 1.
//using (var sw = new StreamWriter("test.txt"))
//{
//    Console.WriteLine("Podaj swój album: ");
//    string album = Console.ReadLine();
//    sw.WriteLine(album);
//}

//Zadanie 2.
//using (var sr = new StreamReader("test.txt"))
//{
//    var line = sr.ReadLine();
//    while (line != null)
//    {
//        Console.WriteLine(line);
//        //Wczytaj kolejną linię
//        line = sr.ReadLine();
//    }
//}

//Zadanie 3.
//using (var sr = new StreamReader("pesels.txt"))
//{
//    int licznik = 0;
//    string pesel = sr.ReadLine();
//    while (pesel != null)
//    {
//        int number = pesel[9] - 48;
//        if (number % 2 == 0)
//        {
//            licznik++;
//        }
//        pesel = sr.ReadLine();
//    }
//    Console.WriteLine("We wczytanym zbiorze jest " +licznik + " żeńskich peseli.");
//}

//Zadanie 4.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Program
    {
        public class Indicator
        {
            public string id { get; set; }
            public string value { get; set; }
        }

        public class Country
        {
            public string id { get; set; }
            public string value { get; set; }
        }
        public class Root
        {
            public Indicator indicator { get; set; }
            public Country country { get; set; }
            public string value { get; set; }
            public string @decimal { get; set; }
            public string date { get; set; }
        }
        public static void Main(string[] args)
        {

            Zad4();
        }

        public static void Zad4()
        {
            List<Root> list;
            using (var sr = new StreamReader("db.json"))
            {
                var json = sr.ReadToEnd();
                list = JsonConvert.DeserializeObject<List<Root>>(json);
            }
            Zad4p1(list);
            Zad4p2(list);
            Zad4p3(list);

            Console.WriteLine("\nZad4 podpunkt 4");
            Console.WriteLine("Wybierz kraj:(US,CN,IN):");
            string kraj = Console.ReadLine();
            Console.WriteLine("Wybierz date:(1960-2019):");
            string data = Console.ReadLine();
            Zad4p4(list, kraj, data);

            Console.WriteLine("\nZad 4 podpunkt 5");
            Console.WriteLine("Wybierz kraj 1:(US,CN,IN):");
            string kraj1 = Console.ReadLine();
            Console.WriteLine("Wybierz date 1:(1960-2019):");
            string data1 = Console.ReadLine();
            Console.WriteLine("Wybierz kraj 2:(US,CN,IN):");
            string kraj2 = Console.ReadLine();
            Console.WriteLine("Wybierz date 2:(1960-2019):");
            string data2 = Console.ReadLine();

            Zad4p5(list, kraj1, data1, kraj2, data2);

            Zad4p6(list, "US", "2000");
        }

        public static void Zad4p1(List<Root> list)
        {
            String in1970 = "";
            String in2000 = "";
            foreach (var root in list)
            {
                if (root.country.id.Equals("IN") && root.date.Equals("1970"))
                {
                    in1970 = root.value;
                }
                if (root.country.id.Equals("IN") && root.date.Equals("2000"))
                {
                    in2000 = root.value;
                }
            }

            long a = Int64.Parse(in1970);
            long b = Int64.Parse(in2000);
            long c = b - a;
            Console.WriteLine("\nZad4 podpunkt 1");
            Console.WriteLine("w 1970: " + a + " w 2000: " + b + " roznica: " + c);
        }
        public static void Zad4p2(List<Root> list)
        {
            String in1970 = "0";
            String in2000 = "0";
            foreach (var root in list)
            {
                if (root.country.id.Equals("US") && root.date.Equals("1965"))
                {
                    in1970 = root.value;
                }
                if (root.country.id.Equals("US") && root.date.Equals("2010"))
                {
                    in2000 = root.value;
                }
            }

            long a = Int64.Parse(in1970);
            long b = Int64.Parse(in2000);
            long c = b - a;
            Console.WriteLine("\nZad4 podpunkt 2");
            Console.WriteLine("w 1965: " + a + " w 2010: " + b + " roznica: " + c);
        }
        public static void Zad4p3(List<Root> list)
        {
            String in1970 = "";
            String in2000 = "";
            foreach (var root in list)
            {
                if (root.country.id.Equals("CN") && root.date.Equals("1980"))
                {
                    in1970 = root.value;
                }
                if (root.country.id.Equals("CN") && root.date.Equals("2018"))
                {
                    in2000 = root.value;
                }
            }

            long a = Int64.Parse(in1970);
            long b = Int64.Parse(in2000);
            long c = b - a;
            Console.WriteLine("\nZad 4 podpunkt 3");
            Console.WriteLine("w 1980: " + a + " w 2018: " + b + " roznica: " + c);
        }
        public static void Zad4p4(List<Root> list, String countryID, String year)
        {
            String pop = "";
            foreach (var root in list)
            {
                if (root.country.id.Equals(countryID) && root.date.Equals(year))
                {
                    pop = root.value;
                }
            }

            Console.WriteLine(countryID + " " + year + " :" + pop);
        }
        public static void Zad4p5(List<Root> list, String countryID1, String year1, String countryID2, String year2)
        {
            String in1 = "";
            String in2 = "";
            foreach (var root in list)
            {
                if (root.country.id.Equals(countryID1) && root.date.Equals(year1))
                {
                    in1 = root.value;
                }
                if (root.country.id.Equals(countryID2) && root.date.Equals(year2))
                {
                    in2 = root.value;
                }
            }

            long a = Int64.Parse(in1);
            long b = Int64.Parse(in2);
            long c = b - a;
            Console.WriteLine("w " + countryID1 + " " + year1 + ": " + a + " \nw " + countryID2 + " " + year2 + ": " + b + " \nroznica: " + c);
        }
        public static void Zad4p6(List<Root> list, String countryID, String year)
        {
            int yearInt = Int16.Parse(year);
            int prevYear = yearInt - 1;
            if (yearInt > 1960 && yearInt < 2020)
            {
                String year1 = "";
                String year2 = "";
                foreach (var root in list)
                {
                    if (root.country.id.Equals(countryID) && root.date.Equals(year))
                    {
                        year1 = root.value;
                    }
                    if (root.country.id.Equals(countryID) && root.date.Equals(prevYear.ToString()))
                    {
                        year2 = root.value;
                    }
                }
                Console.WriteLine("\nZad 4 podpunkt 6");
                Console.WriteLine(countryID + " " + year1 + " :" + year2);
                long a = Int64.Parse(year1);
                long b = Int64.Parse(year2);
                double c = (double)(a - b) / b;
                Console.WriteLine(c);
            }
        }
    }
}
