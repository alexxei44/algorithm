using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3A
{
    class Movie : Media,IEncryptable
    {
        public string Director { get; set; }
        public string Summary { get; set; }
        public Movie(string title, int year, string Director, string Summary) : base(title, year)
        {
            this.Director = Director;
            this.Summary = Summary;
        }
        public override string ToString()
        {
            return $"Movie title: {Title} {Year} \r\n Director: {Director}";
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
