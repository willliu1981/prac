using chapter9example3and4.myClass;
using System;
using System.Collections.Generic;

namespace chapter9example3and4
{
    class Author : Card
    {
        private static Dictionary<Int16, Author> _instance;
        public static Dictionary<Int16, Author> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Dictionary<Int16, Author>();
                    CreateNewDefaultAuthorInstance();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }
        public string Name { get; private set; }
        public Phone Phone { get; private set; }
        public string Email { get; private set; }

        private Author()
        {
            Phone = Phone.CreateEmptyInstance();
            Name = "";
        }

        public static Author GetAuthor(short index)
        {
            Author author;
            if (!Instance.TryGetValue(index, out author))
            {
                author = new Author();
            }
            return author;
        }

        private static void CreateNewDefaultAuthorInstance()
        {
            Author a = new Author();
            a.Name = "David";
            a.Phone = Phone.GetPhone(1);
            a.Email = "yyy@xxx.com";
            SetAuthor(1, a.Name, a.Phone, a.Email);
            a = new Author();
            a.Name = "Mary";
            a.Phone = Phone.GetPhone(2);
            a.Email = "ccc@fff.com";
            SetAuthor(2, a.Name, a.Phone, a.Email);
            a = new Author();
            a.Name = "John";
            a.Phone = Phone.GetPhone(3);
            a.Email = "ddd@eee.com";
            SetAuthor(3, a.Name, a.Phone, a.Email);
        }

        public static void SetAuthor(short index, string name, Phone phone, string email)
        {
            Author author;
            if (!Instance.TryGetValue(index, out author))
            {
                author = new Author();
                Instance.Add(index, author);
            }
            if (index > Max) Max = index;
            author.Name = name;
            author.Phone = phone;
            author.Email = email;
        }

        public static void RemoveAuthor(short index)
        {
            if (Instance.ContainsKey(index))
            {
                Instance.Remove(index);
            }
        }

        public static Author CreateEmptyInstance()
        {
            return new Author();
        }

        public override string ToString()
        {
            return ""+Name;
        }
    }
}




