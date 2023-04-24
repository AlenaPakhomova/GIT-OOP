using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
    /// <summary>
    /// Класс, описывающий абстракцию списка, 
    /// содержащего объекты класса персон
    /// </summary>
    public class PersonList
    {
        /// <summary>
        /// Список людей
        /// </summary>
        public List<PersonBase> people = new List<PersonBase>();

        /// <summary>
        /// Добавление людей
        /// </summary>
        /// <param name="person">люди</param>
        public void AddPerson(PersonBase person)
        {
            people.Add(person);
        }

        /// <summary>
        /// Удаление элементов (имён)
        /// </summary>
        /// <param name="name">имя</param>
        /// <returns>Удаление людей</returns>
        public int RemovePersonByName(string name)
        {
            int deleteName = people.RemoveAll(n => n.Name == name);
            return deleteName;
        }

        /// <summary>
        /// Удаление элементов из списка по индексу
        /// </summary>
        /// <param name="index">индекс элемента</param>
        ///  <exception cref="IndexOutOfRangeException">Элементы с
        ///  несуществующими индексами</exception>
        public void RemovePersonByIndex(int index)
        {
            int indexNumber = people.Count - 1;
            if (indexNumber < index)
            {
                throw new IndexOutOfRangeException($"Элемента с индексом" +
                    $" {index} не существует");
            }
            else
            {
                people.RemoveAt(index);
            }
        }

        /// <summary>
        /// Поиск элемента по индексу
        /// </summary>
        /// <param name="index">индекс элемента</param>
        /// <returns>Элемент с определенным индексом</returns>
        /// <exception cref="IndexOutOfRangeException">Элементы с 
        /// несуществующии индексами</exception>
        public PersonBase FindPersonByIndex(int index)
        {
            int indexNumber = people.Count - 1;
            if (indexNumber < index)
            {
                throw new IndexOutOfRangeException($"Элемента с индексом" +
                    $" {index} не существует");
            }
            else
            {
                return people[index];
            }
        }

        /// <summary>
        /// Возвращает индекс элемента при наличие его в списке
        /// </summary>
        /// <param name="name">имя</param>
        /// <returns>индекс</returns>
        public int ReturnIndexOfperson(string name)
        {
            int returnName = people.FindIndex(r => r.Name == name);
            return returnName;
        }

        /// <summary>
        /// Очистка списка
        /// </summary>
        public void ClearPerson()
        {
            people.Clear();
        }

        /// <summary>
        /// Получение количества элементов в списке
        /// </summary>
        public int CountPersonInList()
        {
            return people.Count();
        }

        
    }
}