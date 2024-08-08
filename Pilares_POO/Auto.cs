using System;

namespace Pilares_POO
{
    public class Auto : Vehiculo
    {
        public int NumeroDePuertas { get; set; }

        public Auto(string marca, string modelo, int año, int kilometraje, int numeroDePuertas)
            : base(marca, modelo, año, kilometraje)
        {
            NumeroDePuertas = numeroDePuertas;
        }

        public override void Encender()
        {
            Console.WriteLine($"El auto {Marca} {Modelo} ({Año}) está encendido.");
        }

        public override void Apagar()
        {
            Console.WriteLine($"El auto {Marca} {Modelo} ({Año}) está apagado.");
        }
    }
}
