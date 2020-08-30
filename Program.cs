using System;

namespace builder_pattern_test
{
    class Program
    {
        static void Main(string[] args)
        {

            var person = new PersonBuilder()
              .Id(10)
              .Firstname("Gary")
              .Lastname("Woodfine")
              .Gender(Gender.Male)
              .DateOfBirth(DateTime.Now)
              .Occupation("Freelance Full-Stack Developer")
              .Build();
            

            Console.WriteLine(person.ToString());
            ReadOnlyTest rot = new ReadOnlyTest();
            rot._person.Firstname = "Mike";
            rot._person.Firstname = "valaki";
            // rot._person = new Person(); ----> Ez hibát dob, mivel a _person readonly. Mivel reference type, ezért a field-jei még módosíthatók, de a reference nem, így nem lehet új értéket adni a _person objectnek (new Person)
            Console.WriteLine(rot._person.Firstname);

            Console.ReadLine();
        }
    }
}
