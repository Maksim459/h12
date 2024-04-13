using System;
using System.Collections.Generic;

class Person : IComparable<Person>
{
    public int Age { get; set; }
    public enum Gender { Female, Male }
    public Gender GenderType { get; set; }

    public int CompareTo(Person other)
    {
        int genderComparison = this.GenderType.CompareTo(other.GenderType);
        if (genderComparison != 0)
        {
            return genderComparison;
        }
        return this.Age.CompareTo(other.Age);
    }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        people.Add(new Person { Age = 25, GenderType = Person.Gender.Female });
        people.Add(new Person { Age = 30, GenderType = Person.Gender.Female });
        people.Add(new Person { Age = 20, GenderType = Person.Gender.Female });
        people.Add(new Person { Age = 35, GenderType = Person.Gender.Female });
        people.Add(new Person { Age = 22, GenderType = Person.Gender.Female });

        people.Add(new Person { Age = 28, GenderType = Person.Gender.Male });
        people.Add(new Person { Age = 32, GenderType = Person.Gender.Male });
        people.Add(new Person { Age = 24, GenderType = Person.Gender.Male });
        people.Add(new Person { Age = 40, GenderType = Person.Gender.Male });
        people.Add(new Person { Age = 27, GenderType = Person.Gender.Male });

        people.Sort();

        foreach (var person in people)
        {
            Console.WriteLine($"Age: {person.Age}, Gender: {person.GenderType}");
        }
    }
}
