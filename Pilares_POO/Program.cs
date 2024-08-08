using System;

namespace Pilares_POO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("For", "Mustang", 2022, 12456, 2);
            Motocicleta motocicleta = new Motocicleta("Harley-Davidson", "Street Glide", 2021, 7000, "Cruiser");
            Camion camion = new Camion("Volvo", "FH16", 2018, 50000, 18000);

            auto.Encender();
            auto.Conducir();
            auto.Apagar();

            motocicleta.Encender();
            motocicleta.Conducir();
            motocicleta.Apagar();

            camion.Encender();
            camion.Conducir();
            camion.Apagar();

            Console.WriteLine("Presione Enter para salir...");
            Console.ReadLine();
        }
    }
}
