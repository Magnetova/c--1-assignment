// Cayden Greer
// CIS 237 - Fall 2022
// 09-16-2022 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_1
{
    internal class Beverage
    {
        private string _id;
        private string _name;
        private string _pack;
        private decimal _price;
        private bool _active;

        public Beverage(string Id, string Name, string Pack, decimal Price, bool Active)
        {
            this._id = Id;
            this._name = Name;
            this._pack = Pack;
            this._price = Price;
            this._active = Active;
        }

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Pack
        {
            get { return _pack; }
            set { _pack = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }

        public override string ToString()
        {
            return _id + "\t" + _name + "\t" + _pack + "\t" + _price + "\t" + _active;
        }




        public Beverage() { }

    }
}
