using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3A
{
    class Song : Media,IEncryptable
    {

        public string Album { get; set; }
        public string Artist { get; set; }
        public Song(string title, int year, string Album, string Artist) : base(title, year)
        {
            this.Album = Album;
            this.Artist = Artist;
        }
        public override string ToString()
        {
            return $"Song title: {Title} {Year} \r\n Artist: {Artist}";
        }

        public string Encrypt()
        {
            return Rot13.Cypher(Album);
        }
        public string Decrypt()
        {
            return Rot13.Cypher(Album);
        }
    }
}
