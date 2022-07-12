using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFOS.BaseClasses
{
    internal class BaseMenuItem
    {
        private enum size
        {
            mini,
            small,
            medium,
            large,
            extra_large
        }
        private double cost;
        private string name;

        BaseMenuItem(double price, string name)
        {
            cost = price;
            this.name = name;
        }
    }
}
