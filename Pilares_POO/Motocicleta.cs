using System;



namespace Pilares_POO
{
    public class Motocicleta : Vehiculo
    {

        public string TipoDeMoto { get; set; }

        public Motocicleta(string marca, string modelo, int año, int kilometraje, string tipoDeMoto)
            : base(marca, modelo, año, kilometraje)
        {
            TipoDeMoto = tipoDeMoto;
        }

        public override void Encender()
        {
            Console.WriteLine($"La motocicleta {Marca} {Modelo} ({Año}), tipo {TipoDeMoto}, está encendida.");
        }

        public override void Apagar()
        {
            Console.WriteLine($"La motocicleta {Marca} {Modelo} ({Año}), tipo {TipoDeMoto}, está apagada.");
        }
    }
}
