using System;


namespace Vehiculos_G2_2022_2
{
    internal abstract class Transporte
    {
        #region Atributos
        internal string marca;
        internal string modelo;
        internal float precio;
        #endregion

        
        public Transporte(string Marca,string Modelo, float Precio)
        {
            this.marca = Marca;
            this.modelo = Modelo;
            this.precio = Precio;

        }

        public float Precio { get; internal set; }
        public string Modelo { get; internal set; }

        public void ImprimirPantallaTrasporte()
        {
            Console.WriteLine("Caracteristicas");
            Console.WriteLine(marca);
        }
    }
   
  
}

