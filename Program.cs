namespace Baalhyttebooking
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Opgave 1
            Boernegruppe boernegruppe = new Boernegruppe() { Id = "SA", Name = "Saffi", Aldersgruppe = "15", AntalDeltagere = 20 };
            Console.WriteLine($"Børnegruppens Id: {boernegruppe.Id}");
            
            Console.WriteLine($"Børnegruppens Name: {boernegruppe.Name}");
           
            Console.WriteLine($"Børnegruppens Aldersgruppe: {boernegruppe.Aldersgruppe}");
            
            Console.WriteLine($"Børnegruppens AntalDeltagere: {boernegruppe.AntalDeltagere}");


            //Opgave 2
            DateTime tids = new DateTime(2023, 12, 27, 15, 00, 00);
           
            DateTime tids1 = new DateTime(2023, 12, 28, 18, 30, 00);
           
            DateTime tids2 = new DateTime(2023, 12, 29, 22, 45, 00);
            
            DateTime tids3 = new DateTime(2023, 12, 31, 23, 40, 00);
            
            Reservation reservation = new Reservation();


            
            Reservation reservation1 = new Reservation() { Id = 1, Tidspunkt = tids, boernegruppe = new Boernegruppe() {Id = "SA1", Name = "Saffis væbner", Aldersgruppe = "væbner", AntalDeltagere = 5 } };
            Reservation reservation2 = new Reservation() { Id = 2, Tidspunkt = tids1, boernegruppe = new Boernegruppe() { Id = "SA2", Name = "Saffis pusling", Aldersgruppe = "pusling", AntalDeltagere = 10 } };
            Reservation reservation3 = new Reservation() { Id = 3, Tidspunkt = tids2, boernegruppe = new Boernegruppe() { Id = "SA3", Name = "Saffis tumling", Aldersgruppe = "tumling", AntalDeltagere = 15 } };
            Reservation reservation4 = new Reservation() { Id = 4, Tidspunkt = tids3, boernegruppe = new Boernegruppe() { Id = "SA4", Name = "Saffis seniorvæbner", Aldersgruppe = "seniorvæbner", AntalDeltagere = 20 } };

            Reservationer reservationsListe = new Reservationer();
            reservationsListe.AddReservation(reservation1);
            reservationsListe.AddReservation(reservation2);
            reservationsListe.AddReservation(reservation3);
            reservationsListe.AddReservation(reservation4);

            reservationsListe.PrintReservation();

            Console.WriteLine("Velkommen til den gyldne og spændende Bålhyttebooking");

            Console.WriteLine("Man kan se metoden RemoveReservation efter der bliver printet, hvor man kan se en af reservationerne bliver fjernet");

            reservationsListe.RemoveReservation(reservation1);
            reservationsListe.PrintReservation();



        }
           
    }
        
    
}