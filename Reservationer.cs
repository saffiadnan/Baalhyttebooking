using Baalhyttebooking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Baalhyttebooking
{
    public class Reservationer
    {
    public int ID { get; set; }

    public List<Reservation> reservations { get; set; }
        public Reservationer()
        {
            DateTime tids = new DateTime(2023, 12, 31);
            reservations = new List<Reservation>();
            reservations.Add(new Reservation() { Id = 1, Tidspunkt=tids, boernegruppe = new Boernegruppe() { Id = "SA", Name = "Saffi", Aldersgruppe = "15", AntalDeltagere = 20 } });
        }
        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        public void PrintReservation()
        {
            foreach (Reservation reservation in reservations)
            {
                Console.WriteLine(reservation);
            }
       
        }
        public void RemoveReservation(Reservation reservation)
        {
            reservations.Remove(reservation);
        }


        }

    }




/*
 

JEG HAR PRØVET I OPGAVE 3 AT LAVE DET SOM EN DICTIONARY, MEN DA JEG IKKE KAN FINDE FEJLEN NÅR JEG KØRER DEN, HAR JEG VALGT OG LAVE DET SOM EN LIST, DA DET VIRKEDE FOR MIG. HERUNDER KAN MAN SE KODE-DELEN FOR
DICTIONARY DELEN. 



 * {
    public class Reservationer
    {
    public int ID { get; set; }

    public Dictionary<int, Reservation> reservations { get; set; }
        public Reservationer()
        {
            DateTime tids = new DateTime(2023, 12, 31);
            reservations = new Dictionary<int, Reservation>();
            reservations.Add(new Reservation() { Id = 1, Tidspunkt=tids, boernegruppe = new Boernegruppe() { Id = "SA", Name = "Saffi", Aldersgruppe = "15", AntalDeltagere = 20 } });
        }
        public void AddReservation(Reservation reservation)
        {
            reservations.Add(reservation);
        }

        public void PrintReservation()
        {
            foreach (Reservation reservation in reservations)
            {
                Console.WriteLine(reservation);
            }
       
        }
        public void RemoveReservation(Reservation reservation)
        {
            reservations.Remove(reservation);
        }


        }

    }
*/




