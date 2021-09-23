using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Globalization;

namespace BookshelfAPIs.Models
{
    public class BooksDatabase
    {
        public List<Book> Books = new List<Book>();

        public BooksDatabase()
        {
            LoadData();
        }
        private static string path = System.Web.HttpContext.Current.Request.MapPath("../Models/data/books_collection.csv");
        
        private static string csvData = System.IO.File.ReadAllText(path);
        private void LoadData()
        {
            foreach (string row in csvData.Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    Books.Add(new Book
                    {
                        ISNB = row.Split(',')[0],
                        Author = row.Split(',')[1],
                        Name = row.Split(',')[2],
                        Date = row.Split(',')[3]
                    }) ;
                }
            }
            Books.RemoveAt(0);
        }
    }
    public class Book
    {
        public string ISNB { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
    }
}