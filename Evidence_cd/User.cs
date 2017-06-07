using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evidence_cd
{
    public class User
    {
        public User(int id, string nick, string password, int level)
        {
            id = _id;
            nick = _nick;
            password = _password;
            level = _level;
        }
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nick;
        public string Nick
        {
            get { return _nick; }
            set { _nick = value; }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private int _level;
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public Produkt Vybírá
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Objednavka Objednává
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