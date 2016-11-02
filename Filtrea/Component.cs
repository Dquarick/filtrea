using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtrea
{
    class Component
    {
        double cost = 0;
        string part = "";

        public void setCost(double _cost)
        {
            cost = _cost;
        }
        public void setPart(string _part)
        {
            part = _part;
        }

        public double getCost()
        {
            return cost;
        }

        public string getPart()
        {
            return part;
        }
    }
}
