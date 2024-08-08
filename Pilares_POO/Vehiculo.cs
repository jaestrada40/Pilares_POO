using System;
using Pilares_POO;

namespace Pilares_POO
{
    public abstract partial class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public int Kilometraje { get; protected set; }


        public Vehiculo(string marca, string modelo, int año, int kilometraje)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            Kilometraje = kilometraje;
        }


        public abstract void Encender();
        public abstract void Apagar();


        public void Conducir()
        {
            
            Console.WriteLine($"Conduciendo {Kilometraje} km. Kilometraje actual: {Kilometraje} km.");
        }
    }
}
