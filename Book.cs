using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3A
{
    class Book : Media, IEncryptable
    {
        public string Author { get; set; }
        public string Summary { get;  set; }
        public Book(string title,int year, string Author,string Summary) : base(title,year)
        {
            this.Author = Author;
            this.Summary = Summary;
        }
        public override string ToString()
        {
            return $"Book title: {Title} {Year} \r\n Author: {Author}";
        }

        public string Encrypt()
        {
            return Rot13.Cypher(Summary);
        }
        public string Decrypt()
        {
            return Rot13.Cypher(Summary);
        }

    }
}
