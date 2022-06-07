using System;

namespace ConsoleApp18
{
    public class Person
    {
        public Person(string name, string surname, DateTime birth, string country, string instrument)
        {
            Name = name;
            Surname = surname;
            Birth = birth;
            Country = country;
            Instrument = instrument;
        }

        public override string ToString()
        {
            return "Name: " + Name + ". Surname: " + Surname + ". Birth: " + Birth + "\nCountry: " + Country + ". Instrument: " + Instrument;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime Birth { get; set; }

        public string Country { get; set; }

        public string Instrument { get; set; }
    }
}
