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
        //TODO: RSDN
        /// <summary>
        /// Объект класса рандом
        /// </summary>
        private static Random random = new Random();

        /// <summary>
        /// Массив мужских имён
        /// </summary>
        private static string[] maleNames = new string[]
        {
            "Максим", "Николай", "Виктор",
            "Евгений", "Андрей", "Роман"
        };
        
        /// <summary>
        /// Массив женских имён
        /// </summary>
        private static string[] femaleNames = new string[]
        {
            "Ксения", "Вероника", "Екатерина",
            "Амелия", "Юлия", "Валерия"
        };

        /// <summary>
        /// Массив мужских фамилий
        /// </summary>
        private static string[] maleSurnames = new string[]
        {
            "Корнилов", "Петров", "Иванов",
            "Сидоров", "Колмаков", "Сипкин"
        };

        /// <summary>
        /// Массив женских фамилий
        /// </summary>
        private static string[] femaleSurnames = new string[]
        {
            "Попова", "Юрина", "Харламова",
            "Копылова", "Парамонова", "Шидловская"
        };

        /// <summary>
        /// Генерация случайного человека (взрослого или ребёнка)
        /// </summary>
        /// <returns>случайного человека</returns>
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

        /// <summary>
        /// Заполнение пола, имени и фамилии человека
        /// </summary>
        /// <param name="person">человек</param>
        /// <param name="gender">пол человека</param>
        public static void RandomGender(PersonBase person, 
            Gender gender = Gender.Default)
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
                person.Surname = maleSurnames[random.Next
                    (1, maleSurnames.Length)];
            }
            else if (person.Gender == Gender.Female)
            {
                person.Name = femaleNames[random.Next
                    (1, femaleNames.Length)];
                person.Surname = femaleSurnames[random.Next
                    (1, femaleSurnames.Length)];
            }

        }

        /// <summary>
        /// Генерация взрослого человека
        /// </summary>
        /// <param name="status">семейное положение</param>
        /// <param name="partner">супруг</param>
        /// <param name="gender">пол человека</param>
        /// <returns>взрослого человека</returns>
        public static Adult RandomAdult
            (MaritalStatus status = MaritalStatus.Single, 
            Adult? partner = null, Gender gender = Gender.Default)
        {
            Adult adult = new Adult();
            RandomGender(adult, gender);

            adult.Age = random.Next(adult.AgeMin, adult.AgeMax);

            MaritalStatus maritalstatus = (MaritalStatus)random.Next(2);

            adult.MaritalStatus = maritalstatus;

            if (maritalstatus == MaritalStatus.Married)
            {
                //TODO: duplication
                if(adult.Gender == Gender.Male)
                {
                    adult.Partner = RandomAdult(MaritalStatus.Married, adult,
                        Gender.Female);
                }
                else
                {
                    adult.Partner = RandomAdult(MaritalStatus.Married, adult,
                        Gender.Male);
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

        /// <summary>
        /// Генерация паспортных данных
        /// </summary>
        /// <param name="adult">взрослый человек</param>
        private static void PassportAdult(Adult adult)
        {
            var passport = (uint)random.Next((int)Adult.MinNumberPassport, 
                (int)Adult.MaxNumberPassport);
            adult.Passport = passport;
        }

        /// <summary>
        /// Генерация ребёнка
        /// </summary>
        /// <returns>ребёнка</returns>
        public static Child RandomChild()
        {
            Child child = new Child();
            RandomGender(child);

            child.Age = random.Next(child.AgeMin, child.AgeMax);

            if(random.Next(0, 2) > 0)
            {
                child.Mother = RandomAdult(MaritalStatus.Married, 
                    child.Father, Gender.Female);
            }

            if(random.Next(0, 2) > 0 )
            {
                child.Father = RandomAdult(MaritalStatus.Married, 
                    child.Mother, Gender.Male);  
            }

            child.School = (School)random.Next(3);

            return child;
        }
    } 
}
