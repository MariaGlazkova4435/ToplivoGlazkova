using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplivo
{
    internal class Toplivo12
    {
        public double Obyem { get; set; }
        public double Plotnost { get; set; } = 2;


        public double Massa(double amountOby)
        {
            return amountOby * Plotnost;
        }
    }
}
