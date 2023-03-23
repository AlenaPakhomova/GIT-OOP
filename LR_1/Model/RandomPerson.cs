using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс случайных людей
    /// </summary>
    public class RandomPerson
    {
        /// <summary>
        /// Генерирует случайного человека.
        /// </summary>
        /// <returns>Возвращает случайного человека</returns>
        public static Person GetRandomPerson()
        {
            Random random = new Random();
            string[] maleNames = new string[]
            {
                "Tom", "Bob", "Mike",
                "Rick", "Mattew", "Robert"
            };

            string[] femaleNames = new string[]
            {
                "Lyla", "Samanta", "Kate",
                "Amelia", "Julia", "Anastasia"
            };

            string[] surnames = new string[]
            {
                "Albertson", "Attwood", "Barlow",
                "Berrington", "Davis", "Forester"
            };


            string name;
            Gender gender = (Gender)random.Next(0, 2);
            switch (gender)
            {
                case Gender.Male:
                    name = maleNames[random.Next(maleNames.Length)];
                    break;
                case Gender.Female:
                    name = femaleNames[random.Next(femaleNames.Length)];
                    break;
                default:
                    return new Person("Default", "Person", 2, Gender.Default);
            }

            string surname = surnames[random.Next(surnames.Length)];

            int age = random.Next(0, Person.AgeMax);

            return new Person(name, surname, age, gender);

        }

    }
}
