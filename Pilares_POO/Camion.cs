using System;


namespace Pilares_POO
{
    public class Camion : Vehiculo
    {
        public int CapacidadDeCarga { get; set; }

        public Camion(string marca, string modelo, int año, int kilometraje, int capacidadDeCarga)
            : base(marca, modelo, año, kilometraje)
        {
            CapacidadDeCarga = capacidadDeCarga;
        }

        public override void Encender()
        {
            Console.WriteLine($"El camión {Marca} {Modelo} ({Año}) está encendido.");
        }

        public override void Apagar()
        {
            Console.WriteLine($"El camión {Marca} {Modelo} ({Año}) está apagado.");
        }
    }
}
