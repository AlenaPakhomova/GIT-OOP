using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс людей.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Имя человека.
        /// </summary>
        public string _name;

        /// <summary>
        /// Фамилия человека.
        /// </summary>
        public string _surname;

        /// <summary>
        /// Возраст человека.
        /// </summary>
        public int _age;

        /// <summary>
        /// Пол человека.
        /// </summary>
        public string _gender;

        /// <summary>
        /// Имя
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                //TODO:
                _name = CorrectNameAndSurname(value);
                _name = ToUpperFirst(value);
            }
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                //TODO:
                _surname = CorrectNameAndSurname(value);
                _surname = ToUpperFirst(value);
            }
        }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = CheckingAge(value);
            }
        }

        /// <summary>
        /// Пол человека
        /// </summary>
        public Gender Gender { get; set; }


        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Person()
        { }

        /// <summary>
        /// Конструктор класса Персон.
        /// </summary>
        /// <param name="name">//TODO: XML</param>
        /// <param name="surname"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        public Person(string name, string surname, int age, Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
        

        /// <summary>
        /// Проверка имени и фамилии.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool CheckingNameAndSurname(string value)
        {
            var regex = new Regex(@"(^[А-я]+(-| [А-я])?[А-я]*$)" +
                "|(^[A-z]+(-| [A-z])?[A-z]*$)");

            return regex.IsMatch(value);

        }

        /// <summary>
        /// Проверка на пустые строки и на непонятные символы
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string CorrectNameAndSurname(string value)
        {
            if (value == string.Empty || value == null)  
            {
                throw new Exception("Пустая строка!");
            }
            else if (!CheckingNameAndSurname(value))
            {
                throw new Exception("Имя и фамилия должны содержать " +
                    "только символы латиницы или кириллицы!");
            }
            else
            {
                return value;
            }

        }

        /// <summary>
        /// Максимальный возраст человека
        /// </summary>
        public static int AgeMax = 130;
        //TODO: AgeMin?

        /// <summary>
        /// Проверка возраста 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int CheckingAge(int number)
        {
            if (number < 0 || number > AgeMax)
            {
                throw new Exception("Возраст должен быть в диапазоне" +
                    $"от 0 до {AgeMax} лет!");
            }
            else
            {
                return number;
            }
        }

        //TODO: remove
        /// <summary>
        /// Проверка пола человека
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int CheckingGender(int number)
        {
            if (number < 0 || number > 1)
            {
                throw new Exception("Введите 0 или 1, где 0 - Male," +
                    "1 - Female!");
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Проебразование в правильные регистры
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToUpperFirst(string value)
        {
            var symbols = new[] { " ", "-" };
            foreach(var symbol in symbols)
            {
                if (value.Contains(symbol))
                {
                    string[] words = value.Split( ' ', '-' );
                    string firstword = words[0];
                    string secondword = words[1];

                    firstword = char.ToUpper(firstword[0]) + firstword.Substring(1).ToLower();
                    secondword = char.ToUpper(secondword[0]) + secondword.Substring(1).ToLower();
                    string fullword = firstword + symbol + secondword;

                    return fullword;
                }              
            }
            return char.ToUpper(value[0]) + value.Substring(1).ToLower();

        }

        /// <summary>
        /// Вывод информации о человеке
        /// </summary>
        /// <returns></returns>
        public string GetInfo()
        {
            return $"Name: {Name}, Surname: {Surname}," +
               $" Age: {Age}, Gender: {Gender} ";
        }
    }
}