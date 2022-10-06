using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SicilyLines
{
    class Periode
    {
        private DateTime dateDebut;
        private DateTime dateFin;

        public Periode(DateTime uneDateDebut, DateTime uneDateFin)
        {
            this.dateDebut = uneDateDebut;
            this.dateFin = uneDateFin;
        }

        public DateTime getDateDebut()
        {
            return this.dateDebut;
        }
        public void setDateDebut(DateTime uneDateDebut)
        {
            this.dateDebut = uneDateDebut;
        }
        public DateTime getDateFin()
        {
            return this.dateFin;
        }
        public void setDateFin(DateTime uneDateFin)
        {
            this.dateFin = uneDateFin;
        }
    }
}
