using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtrea
{
    class Component
    {
        double _cost = 0;
        string _name = "";

        public double Cost
        {
            get { return _cost;}
            set { _cost = value;}
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
