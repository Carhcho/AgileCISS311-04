using System;
using System.Collections.Generic;
using System.Text;

namespace dropbox04
{
    class NonPerishable
    {
        private string name;
        private DateTime expiration;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Expiration
        {
            get { return expiration; }
            set { expiration = value; }
        }

        public NonPerishable(string name, DateTime expiration)
        {
            this.name = name;
            this.expiration = expiration;
        }

        public override string ToString()
        {
            string str;
            str = string.Format($"{name} must be consumed before {expiration}.");
            return str;
        }
    }
}
