using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evidence_cd
{
    public class Produkt
    {
        public Produkt(int id, string album, string artist, long year, string genre, string price)
        {
            id = _id;
            album = _album;
            artist = _artist;
            year = _year;
            genre = _genre;
            price = _price;
        }
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _album;
        public string Album
        {
            get { return _album; }
            set { _album = value; }
        }
        private string _artist;
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        private long _year;
        public long Year
        {
            get { return _year; }
            set { _year = value; }
        }
        private string _genre;
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        private string _price;
        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Detail Detail
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Objednavka Shrnutí
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}