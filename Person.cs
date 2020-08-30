using System;
using System.Collections.Generic;
using System.Text;

namespace builder_pattern_test
{
    public class Person
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Occupation { get; set; }

        public Gender Gender { get; set; }

        public override string ToString()
        {
            return $"Person with id: {Id}  with date of birth {DateOfBirth.ToLongDateString()}   and name {string.Concat(Firstname, " ", Lastname)} is a {Occupation}";
        }
    }
}
