using System;


namespace Vehiculos_G2_2022_2
{
     class Tractor:Transporte
    {
        public Tractor(string Marca, string Modelo, float Precio) : base(Marca, Modelo, Precio)
        {
            base.marca = Marca;
            base.Modelo = Modelo;
            base.Precio = Precio;

        }

        public void ImprimirPantalla()
        {
            //base.ImprimirPantallaTrasporte();
            Console.WriteLine(base.marca);
            Console.WriteLine(base.Modelo);
            Console.WriteLine(base.Precio);


        }
    }
}
