using System;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            string name, surname, country, instrument;
            DateTime birth;
        start:
            try
            {
                Console.WriteLine("Enter amount of people");
                amount = Convert.ToInt32(Console.ReadLine());
                Person[] people = new Person[amount];
                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine("Enter " + (i + 1) + " person`s name");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter " + (i + 1) + " person`s surname");
                    surname = Console.ReadLine();
                    Console.WriteLine("Enter " + (i + 1) + " person`s country");
                    country = Console.ReadLine();
                    Console.WriteLine("Enter " + (i + 1) + " person`s instrument(guitar, piano, violin, cello)");
                    instrument = Console.ReadLine();
                    Console.WriteLine("Enter " + (i + 1) + " person`s birthday");
                    birth = Convert.ToDateTime(Console.ReadLine());
                    people[i] = new Person(name, surname, birth, country, instrument);
                    Console.WriteLine("\n\n\n\n");
                }
                foreach (var item in people)
                {
                    Console.WriteLine(item);
                }
                double avg;
                int year = 0;
                foreach (var item in people)
                {
                    year += DateTime.Now.Year - item.Birth.Year;
                }
                avg = year / people.Length;
                Console.WriteLine("middle age: "+avg);
                Console.WriteLine("Enter country to search people, who has year less than average");
                country = Console.ReadLine();
                Console.WriteLine("People, who has year year less than average in " + country);
                foreach (var it in people)
                {
                    if (it.Country == country)
                    {
                        if (DateTime.Now.Year - it.Birth.Year < avg)
                        {
                            Console.WriteLine(it);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Try again");
                goto start;
            }
        }
    }
}
