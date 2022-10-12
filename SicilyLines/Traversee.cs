using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines
{
    class Traversee
    {
        private DateTime date;
        private DateTime heure;

        public DateTime getDate()
        {
            return this.date;
        }
        public void setDate(DateTime nouvDate)
        {
            this.date = nouvDate;
        }
        public DateTime getHeure()
        {
            return this.heure;
        }
        public void setHeure(DateTime nouvHeure)
        {
            this.heure = nouvHeure;
        }
    }
}
