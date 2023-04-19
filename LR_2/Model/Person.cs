using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
    /// <summary>
    /// Класс людей.
    /// </summary>
    public abstract class PersonBase
    {
        /// <summary>
        /// Имя человека.
        /// </summary>
        protected string _name;

        /// <summary>
        /// Фамилия человека.
        /// </summary>
        protected string _surname;

        /// <summary>
        /// Возраст человека.
        /// </summary>
        protected int _age;

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
                string tmpName = ToUpperFirst(CorrectNameAndSurname(value));

                if (_surname != null)
                {
                    CheckingLanguage(_name, tmpName);
                }

                _name = tmpName;

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
                string tmpSurname = ToUpperFirst
                    (CorrectNameAndSurname(value));
               
                if(_name != null)
                {
                    CheckingLanguage(_name, tmpSurname);                   
                }

                _surname = tmpSurname;
              
            }
        }

        /// <summary>
        /// Возраст
        /// </summary>
        public abstract int Age { get; set; }

        /// <summary>
        /// Пол человека
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Конструктор по умолчанию. Дефолтный конструктор.
        /// </summary>
        public PersonBase()
        { }

        /// <summary>
        /// Конструктор класса Персон.
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="age">возраст</param>
        /// <param name="gender">пол человека</param>
        public PersonBase(string name, string surname, int age, 
            Gender gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Проверка двойного имени и двойной фамилии.
        /// </summary>
        /// <param name="value">имя или фамилия</param>
        /// <returns>имя или фамилию</returns>
        public static bool CheckingNameAndSurname(string value)
        {
            var regex = new Regex(@"(^[А-я]+(-| [А-я])?[А-я]*$)" +
                "|(^[A-z]+(-| [A-z])?[A-z]*$)");
         
                return regex.IsMatch(value);                    
        }

        /// <summary>
        /// Проверка на двойное тире и двойной пробел
        /// </summary>
        /// <param name="value">имя или фамилия</param>
        /// <returns> имя или фамилия</returns>
        public static bool CheckSymbol(string value)
        {
            var regex1 = new Regex(@"(^[А-яA-z]*(-| )?[А-яA-z]*$)");
            return regex1.IsMatch(value);
        }

        /// <summary>
        /// Проверка на пустые строки и на непонятные символы
        /// </summary>
        /// <param name="value">имя или фамилия</param>
        /// <returns>Возвращает имя или фамилию</returns>
        /// <exception cref="Exception">Проверка на пустую строку
        /// и неправльные символы</exception>
        public static string CorrectNameAndSurname(string value)
        {
            if (value == string.Empty)
            {
                throw new Exception("Пустая строка!");
            }
            else if(!CheckSymbol(value))
            {
                throw new Exception("Может содержать буквы," +
                    " один дефис или один пробел!");
            }
            else if (!CheckingNameAndSurname(value))
            {
                throw new Exception("Может содержать символы латиницы или" +
                    " кириллицы!");
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// Проверка на совпадение языка в имени и фамилии.
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <returns>Возращает имя и фамилию</returns>
        /// <exception cref="Exception">Язык различается</exception>
        public void CheckingLanguage(string name, string surname)
        {

            Language nameLanguege = DefineLanguage(name);
            Language surnameLanguege = DefineLanguage(surname);
            if (nameLanguege != surnameLanguege)
            {
                throw new ArgumentException("Язык имени и фамилии " +
                    "должен совпадать!");
            }
        }
        
        /// <summary>
        /// Проверка на язык.
        /// </summary>
        /// <param name="str">имя и фамилия</param>
        /// <returns>язык</returns>
        private Language DefineLanguage(string word) 
        {
            Regex latin = new Regex(@"[a-zA-Z]");
            Regex cyrillic = new Regex(@"[а-яА-Я]");

            if (latin.IsMatch(word))
            {
                return Language.Latin;
            }
            else if (cyrillic.IsMatch(word))
            {
                return Language.Cyrillic;
            }
            else
            {
                throw new ArgumentException("Разрешено вводить только" +
                    "символы кирицицы и латиницы!");
            }
        }
        
        /// <summary>
        /// Максимальный возраст человека
        /// </summary>
        public abstract int AgeMax { get; }

        /// <summary>
        /// Минимальный возраст человека
        /// </summary>
        public abstract int AgeMin { get; }

       
 
        /// <summary>
        /// Пребразование в правильные регистры
        /// </summary>
        /// <param name="value"> имя или фамилия </param>
        /// <returns> Возращает имя или фамилию </returns>
        public static string ToUpperFirst(string value)
        {
            var symbols = new[] { " ", "-" };
            foreach (var symbol in symbols)
            {
                if (value.Contains(symbol))
                {
                    string[] words = value.Split(' ', '-');
                    string firstword = words[0];
                    string secondword = words[1];

                    firstword = char.ToUpper(firstword[0]) +
                        firstword.Substring(1).ToLower();
                    secondword = char.ToUpper(secondword[0]) +
                        secondword.Substring(1).ToLower();
                    string fullword = firstword + symbol + secondword;

                    return fullword;
                }
            }
            return char.ToUpper(value[0]) + value.Substring(1).ToLower();
        }

        /// <summary>
        /// Вывод информации о человеке
        /// </summary>
        /// <returns>Строку с информацией о человеке</returns>
        public virtual string GetInfo()
        {
            return $"Имя: {Name}, Фамилия: {Surname}," +
                   $" Возраст: {Age}, Пол: {Gender} ";
        }


        
    }
}