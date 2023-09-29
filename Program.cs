/*
 * 4)  Створіть клас «Магазин». Необхідно зберігати у полях класу: 
 * назву магазину, адреса, опис профілю магазину, контактний телефон, email. 
 * Реалізуйте методи класу для введення даних,
 * виведення даних. Реалізуйте доступ до окремих полів через методи класу.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Store
{
    using System;

    class Store
    {
        private string name;
        private string address;
        private string description;
        private string contactPhone;
        private string email;

        public Store(string name, string address, string description, string contactPhone, string email)
        {
            this.name = name;
            this.address = address;
            this.description = description;
            this.contactPhone = contactPhone;
            this.email = email;
        }

        public void InputData()
        {
            Console.Write("Введите название магазина: ");
            name = Console.ReadLine();

            Console.Write("Введите адрес магазина: ");
            address = Console.ReadLine();

            Console.Write("Введите описание профиля магазина: ");
            description = Console.ReadLine();

            Console.Write("Введите контактный телефон: ");
            contactPhone = Console.ReadLine();

            Console.Write("Введите email: ");
            email = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("Название магазина: " + GetName());
            Console.WriteLine("Адрес: " + GetAddress());
            Console.WriteLine("Описание профиля магазина: " + GetDescription());
            Console.WriteLine("Контактный телефон: " + GetContactPhone());
            Console.WriteLine("Email: " + GetEmail());
        }

        public string GetName()
        {
            return name;
        }

        public string GetAddress()
        {
            return address;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public string GetEmail()
        {
            return email;
        }
    }

    class Program
    {
        static void Main()
        {
            Store store = new Store("", "", "", "", "");
            store.InputData();
            Console.WriteLine("\nИнформация о магазине:");
            store.DisplayData();
            Console.ReadLine();
        }
    }

}
