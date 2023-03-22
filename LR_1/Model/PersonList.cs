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
    public class PersonList
    {
        /// <summary>
        /// Список людей.
        /// </summary>
        public List<Person> people = new List<Person>();

        /// <summary>
        /// Добавление людей
        /// </summary>
        /// <param name="person"></param>
        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        /// <summary>
        /// Удаление элементов (имён)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int RemovePersonByName(string name)
        {
            int delName = people.RemoveAll(n => n.Name == name);
            return delName;

        }


        /// <summary>
        /// Удаление элементов из списка по индексу
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="IndexOutOfRangeException"></exception>
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
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public Person FindPersonByIndex(int index)
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
        /// <param name="name"></param>
        /// <returns></returns>
        public int ReturnIndexOfperson(string name)
        {
            int retName = people.FindIndex(r => r.Name == name);
            return retName;

        }


        /// <summary>
        /// Очистка списка
        /// </summary>
        /// <param name="person"></param>
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
