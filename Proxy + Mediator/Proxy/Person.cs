using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Proxy___Mediator.Proxy
{
    internal class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public Passport passport { get; }

        public Person(int personId, string firstName, string lastName, string address, int age)
        {
            PersonId = personId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Age = age;
            passport = new Passport();
        }

        public static Person GeneratePerson()
        {
            Random rnd = new();
            string[] firstName_bank = { "aaron", "abdul", "abe", "abel", "abraham", "adam", "adan", "adolfo", "adolph", "adrian", "abby", "abigail", "adele", "adrian" };
            string[] lastNames_bank = { "abbott", "acosta", "adams", "adkins" };
            string[] streets_bank = { "Laskov", "Herzl", "Ben-Gurion", "Yigal Allon", "Rabinovitz" };
            string[] cities_bank = { "Tel-Aviv", "Holon", "Herzliya", "Haifa", "Ramat Gan" };
            int personId = rnd.Next(100000000, 999999999);
            string firstName = firstName_bank[rnd.Next(0, firstName_bank.Length - 1)];
            string lastName = lastNames_bank[rnd.Next(0, lastNames_bank.Length - 1)];
            int age = rnd.Next(121);
            string address = $"{streets_bank[rnd.Next(0, streets_bank.Length - 1)]} {rnd.Next(1, 199)}, {cities_bank[rnd.Next(0, cities_bank.Length - 1)]}";
            Person p1 = new Person(personId, firstName, lastName, address, age);
            return p1;
        }

        public override string ToString()
        {
            //var options = new JsonSerializerOptions { WriteIndented = true };
            //options.Converters.Add(new System.Text.Json.Serialization.JsonStringEnumConverter());
            //return JsonSerializer.Serialize(this, options);
            var options = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(this, options);

        }

    }
}
