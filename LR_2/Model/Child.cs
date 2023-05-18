using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для ребёнка
    /// </summary>
    public class Child : PersonBase
    {
        /// <summary>
        /// Базовый конструктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Child(string name, string surname, int age, Gender gender)
           : base(name, surname, age, gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Child()
        {

        }

        /// <summary>
        /// Мама
        /// </summary>
        public Adult? Mother { get; set; }

        /// <summary>
        /// Папа
        /// </summary>
        public Adult? Father { get; set; }

        /// <summary>
        /// Переопределение минимального возраста
        /// </summary>
        public override int AgeMin => 7;

        /// <summary>
        /// Переопределние максимального возраста
        /// </summary>
        public override int AgeMax => 17;

        /// <summary>
        /// Школа
        /// </summary>
        public School School { get; set; }



        /// <summary>
        /// Переопределение метода о выводе информации человеке
        /// </summary>
        /// <returns>информация о ребёнке</returns>
        public override string GetInfo()
        {
            var personInfo = base.GetInfo();
            if (Mother != null)
            {
                personInfo += $"\nMother: {Mother.Name} " +
                    $"{Mother.Surname}";
            }
            if (Father != null)
            {
                personInfo += $"\nFather: {Father.Name} " +
                    $"{Father.Surname}";
            }
            if (Mother == null)
            {
                personInfo += "\nThis child doesn't have a mother.";
            }
            if (Father == null)
            {
                personInfo += "\nThis child doesn't have a father.";
            }
            if (Mother == null && Father == null)
            {
                personInfo += "\nOrphan";
            }

            if (School == School.Loafer)
            {
                personInfo += $"\nLoafer";
            }
            else
            {
                personInfo += $"\nSchool: {School}";
            }
            return personInfo;
        }

        /// <summary>
        /// Любимые сладости ребёнка.
        /// </summary>
        /// <returns></returns>
        public string FavoriteSweet()
        {
            string[] sweets = new string[]
            {
                "milk chocolate", "cake",
                "ice cream", "marmalade"
            };
            string sweet = sweets[new Random().Next(sweets.Length)];

            return $"\n{GetNameAndSurname} prefers {sweet}.";
        }
    }
}

