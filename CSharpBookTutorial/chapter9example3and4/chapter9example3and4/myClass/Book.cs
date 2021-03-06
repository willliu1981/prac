﻿using chapter9example3and4.myClass;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace chapter9example3and4
{
    class Book : Card
    {
        private static Dictionary<Int16, Book> _instance;
        public static Dictionary<Int16, Book> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Dictionary<Int16, Book>();
                    CreateNewDefaultBookInstance();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }
        public string No { get; private set; }
        public string Title { get; private set; }
        public Author Author { get; private set; }
        private int _price;
        public int Price
        {
            get { return _price; }
            private set
            {
                _price = value;
                if (value < 0) _price = 0;
            }
        }

        private Book()
        {
            Author = Author.CreateEmptyInstance();
        }

        public static Book GetBook(short index)
        {
            Book book;
            if (!Instance.TryGetValue(index, out book))
            {
                book = new Book();
            }
            return book;
        }

        private static void CreateNewDefaultBookInstance()
        {
            Book b = new Book();
            b.No = "b1234";
            b.Title = "C#";
            b.Author = Author.GetAuthor(2);
            b.Price = 520;
            SetBook(1, b.No, b.Title, b.Author, b.Price);
            b = new Book();
            b.No = "b1235";
            b.Title = "Java";
            b.Author = Author.GetAuthor(1);
            b.Price = 620;
            SetBook(2, b.No, b.Title, b.Author, b.Price);
        }

        public static void SetBook(short index, string no, string title, Author author, string price)
        {
            int myPrice;
            try
            {
                myPrice = Convert.ToInt32(price);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.StackTrace);
                myPrice = 0;
            }
            SetBook(index, no, title, author, myPrice);
        }
        public static void SetBook(short index, string no, string title, Author author, int price)
        {
            Book book;
            if (!Instance.TryGetValue(index, out book))
            {
                book = new Book();
                Instance.Add(index, book);
            }
            if (index > Max) Max = index;
            book.No = no;
            book.Title = title;
            book.Author = author;
            book.Price = price;
        }

        public static void RemoveBook(short index)
        {
            if (Instance.ContainsKey(index))
            {
                Instance.Remove(index);
            }
        }

    }
}
