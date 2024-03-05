using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    struct Linear
    {
        private double k;
        private double b;

        public Linear(double k, double b)
        {
            this.k = k;
            this.b = b;
        }

        public string Root()
        {
            if (k == 0)
            {
                return "Неверный формат уравнения";
            }
            else
            {
                double r = -b / k;
                return $" x = {r}";
            }
        }
    }
}
