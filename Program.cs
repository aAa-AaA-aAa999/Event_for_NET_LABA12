using System;

namespace Laba12
{

    class Event //первый класс с событием 
    {
        public string name;
        public delegate void EventDelegate(string stroka);
        public Event(string name)
        {
            this.name = name;
        }

        public event EventDelegate ED;
        public void generirivanieEvanta() //В классе должен быть описан метод для генерирования события
        {
            if (ED != null) //если не пуста
            {
                ED(name); //непуста
            }
            else //если пуста
            {
                Console.WriteLine("пуста"); //пуста
            }
        }
    }

    class Message
    {
        public string str;
        public Message(string str) //содержание сообщения
        {
            this.str = str;
        }
        public void Display(string name)
        {
            Console.WriteLine($"{name} сгенерирован"); //Второй класс, описанный в программе, должен содержать метод с текстовым аргументом, в который записывается значение своего текстового аргумента
            Console.WriteLine($"сообщение: {str}");
        }
    }

    class Program
    {
        static void Main(string[] args) //Создать два объекта первого класса и один объект второго класса. 
        {
            Event ob = new Event("первый объект");
            Event ob2 = new Event("второй объект");
            Message message = new Message("скрыто"); //содержание сообщения

            ob.ED += message.Display; //присваивание сообщения объектам
            ob2.ED += message.Display;

            ob.generirivanieEvanta(); //генерация события
            ob2.generirivanieEvanta();
        }
    }
}