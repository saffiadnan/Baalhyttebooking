using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Baalhyttebooking
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime Tidspunkt { get; set; }
        public Boernegruppe boernegruppe { get; set; }

        public override string ToString()
        {
            return $"ReservationsId = " + Id + "Tidspunkt = " + Tidspunkt + "boernegruppe = " + boernegruppe;
        }
    }
    

}
