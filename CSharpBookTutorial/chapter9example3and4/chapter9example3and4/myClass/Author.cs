﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace chapter9example3and4
{
    public class Author
    {
        public static int Max
        {
            get { return Instance.Count; }
        }
        private static Dictionary<Int16, Author> _instance;
        public  static Dictionary<Int16, Author> Instance
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
            Instance.Add(1, a);
            a = new Author();
            a.Name = "Mary";
            a.Phone = Phone.GetPhone(2);
            a.Email = "ccc@fff.com";
            Instance.Add(2, a);
            a = new Author();
            a.Name = "John";
            a.Phone = Phone.GetPhone(3);
            a.Email = "ddd@eee.com";
            Instance.Add(3, a);
        }

        public static void SetAuthor(short index, string name, Phone phone, string email)
        {
            Author author;
            if (!Instance.TryGetValue(index, out author))
            {
                author = new Author();
                Instance.Add(index, author);
            }
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

        public static BindingList<Author> ToBindingList()
        {
            ////BindingList<Author> list = new BindingList<Author>(Instance.ToList<Author>());
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //dic.ToList<KeyValuePair<int, int>>();

            //list.Clear();
            //List<Author> myList = Instance.Values;

            //return Instance
            return null;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}



