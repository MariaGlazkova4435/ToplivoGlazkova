using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toplivo
{
    internal class Station
    {
        public void Zapravit(Hranilishe hranilishe, double amount)
        {
            hranilishe.Amount -= amount;
        }

        public void AddTop(Hranilishe hranilishe, double amount)
        {
            hranilishe.Amount += amount;
        }
    }
}
