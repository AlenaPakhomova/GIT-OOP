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
            "Максим", "Николай", "Виктор",
            "Евгений", "Андрей", "Роман"

        };

        private static string[] femaleNames = new string[]
        {
            "Ксения", "Вероника", "Екатерина",
            "Амелия", "Юлия", "Валерия"

        };

        private static string[] maleSurnames = new string[]
        {
            "Корнилов", "Петров", "Иванов",
            "Сидоров", "Колмаков", "Сипкин"

        };

        private static string[] femaleSurnames = new string[]
        {
            "Попова", "Юрина", "Харламова",
            "Копылова", "Парамонова", "Шидловская"

        };

        public static PersonBase GreateRandomPerson()
        {
            if(random.Next(0, 2) > 0)
            {
                return RandomChild();
            }
            else
            {
                return RandomAdult();
            }
        }


        public static void RandomGender(PersonBase person, Gender gender = Gender.Default)
        {
            if(gender == Gender.Default)
            {
                person.Gender = (Gender)random.Next(0, 2);
            }
            else
            {
                person.Gender = gender;
            }

            if(person.Gender == Gender.Male)
            {
                person.Name = maleNames[random.Next(1, maleNames.Length)];
                person.Surname = maleSurnames[random.Next(1, maleSurnames.Length)];
            }
            else if (person.Gender == Gender.Female)
            {
                person.Name = femaleNames[random.Next(1, femaleNames.Length)];
                person.Surname = femaleSurnames[random.Next(1, femaleSurnames.Length)];
            }

        }

        public static Adult RandomAdult(MaritalStatus status = MaritalStatus.Single, Adult? partner = null, Gender gender = Gender.Default)
        {
            Adult adult = new Adult();
            RandomGender(adult, gender);

            adult.Age = random.Next(adult.AgeMin, adult.AgeMax);

            MaritalStatus maritalstatus = (MaritalStatus)random.Next(2);

            adult.MaritalStatus = maritalstatus;

            if (maritalstatus == MaritalStatus.Married)
            {
                if(adult.Gender == Gender.Male)
                {
                    adult.Partner = RandomAdult(MaritalStatus.Married, adult, Gender.Female);
                }
                else
                {
                    adult.Partner = RandomAdult(MaritalStatus.Married, adult, Gender.Male);
                }               
            }
            else
            {
                adult.MaritalStatus = status;
            }

            adult.Job = (Job)random.Next(5);

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

            if(random.Next(0, 2) > 0)
            {
                child.Mother = RandomAdult(MaritalStatus.Married, child.Father, Gender.Female);
               
            }

            if(random.Next(0, 2) > 0 )
            {
                child.Father = RandomAdult(MaritalStatus.Married, child.Mother, Gender.Male);
             
            }

            child.School = (School)random.Next(3);

            return child;
        }


       

    }
  
}
