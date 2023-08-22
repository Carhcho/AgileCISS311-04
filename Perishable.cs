using System;
using System.Collections.Generic;
using System.Text;

namespace dropbox04
{
    class Perishable
    {
        private string name;
        private int temperature;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public Perishable(string name, int temperature)
        {
            this.name = name;
            this.temperature = temperature;
        }

        public override string ToString()
        {
            string str;
            str = string.Format($"{name} is perishable and should keep the temperature around {temperature}");
            return str;
        }
    }
}
