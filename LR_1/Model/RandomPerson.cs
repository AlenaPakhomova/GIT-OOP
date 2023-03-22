using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RandomPerson
    {
        /// <summary>
        /// Генерирует случайного человека.
        /// </summary>
        /// <returns></returns>
        public static Person GetRandomPerson()
        {
            Random random = new Random();

            string[] _maleNames = new string[]
            {
                "Tom", "Bob", "Mike",
                "Rick", "Mattew", "Robert"
            };

            string[] _femaleNames = new string[]
            {
                "Lyla", "Samanta", "Kate",
                "Amelia", "Julia", "Anastasia"
            };

            string[] _surnames = new string[]
            {
                "Albertson", "Attwood", "Barlow",
                "Berrington", "Davis", "Forester"
            };


            string name;
            Gender gender = (Gender)random.Next(0, 2);
            switch (gender)
            {
                case Gender.Male:
                    name = _maleNames[random.Next(_maleNames.Length)];
                    break;
                case Gender.Female:
                    name = _femaleNames[random.Next(_femaleNames.Length)];
                    break;
                default:
                    return new Person("Default", "Person", 2, Gender.Default);
            }

            string surname = _surnames[random.Next(_surnames.Length)];

            int age = random.Next(0, Person.AgeMax);

            return new Person(name, surname, age, gender);

        }

    }
}
