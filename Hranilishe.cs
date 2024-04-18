using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplivo
{
    internal class Hranilishe
    {
        public double ObyemTopliva { get; set; } = 20;
        public double Amount { get; set; } = 100;

        public double ObyemToplivaEnd()
        {
            return ObyemTopliva*Amount;
        }
    }
}
