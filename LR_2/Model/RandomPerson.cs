using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Model
{

    /// <summary>
    /// Класс случайных людей
    /// </summary>
    public class RandomPerson
    {
        private static Random random = new Random();

        private static string[] maleNames = new string[]
        {
            "Tom", "Bob", "Mike",
            "Rick", "Mattew", "Robert"

        };

        private static string[] femaleNames = new string[]
        {
            "Lyla", "Samanta", "Kate",
            "Amelia", "Julia", "Anastasia"

        };

        private static string[] surnames = new string[]
        {
            "Albertson", "Attwood", "Barlow",
            "Berrington", "Davis", "Forester"

        };

        public static PersonBase GreateRandomPerson()
        {
            if(random.Next(0, 2) != 0)
            {
                return RandomChild();
            }
            else
            {
                return RandomAdult();
            }
        }


        public static void RandomGender(PersonBase person)
        {
            Gender gender = Gender.Default;
            switch (gender)
            {
                case Gender.Male:
                    person.Name = maleNames[random.Next(maleNames.Length)];
                    break;
                case Gender.Female:
                    person.Name = femaleNames[random.Next(femaleNames.Length)];
                    break;
            }
            person.Surname = surnames[random.Next(surnames.Length)];
        }

        public static Adult RandomAdult(MaritalStatus status = MaritalStatus.Single, Adult partner = null)
        {
            Adult adult = new Adult();
            RandomGender(adult);

            adult.Age = random.Next(adult.AgeMin, adult.AgeMax);

            MaritalStatus maritalstatus = (MaritalStatus)random.Next(2);

            adult.MaritalStatus = maritalstatus;

            if (maritalstatus == MaritalStatus.Married)
            {
                adult.Partner = RandomAdult(MaritalStatus.Single, adult);
            }
            else
            {
                adult.MaritalStatus = MaritalStatus.Married;
                adult.Partner = partner;
            }

            adult.Job = (Job)random.Next(8);

            PassportAdult(adult);

            return adult;
        }

        private static void PassportAdult(Adult adult)
        {
            var passport = (uint)random.Next((int)Adult.MinNumberPassport, 
                (int)Adult.MaxNumberPassport);
            adult.Passport = passport;
        }

        public static Child RandomChild()
        {
            Child child = new Child();
            RandomGender(child);

            child.Age = random.Next(child.AgeMin, child.AgeMax);

            var mother = random.Next(0, 2);

            if(mother > 0)
            {
                child.Mother = RandomAdult();
            }

            var father = random.Next(0, 2);
            
            if(father > 0 )
            {
                child.Father = RandomAdult();
            }

            child.School = (School)random.Next(4);

            return child;
        }


       

    }
  
}
