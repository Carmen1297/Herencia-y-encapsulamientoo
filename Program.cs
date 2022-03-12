using System;



namespace Vehiculos_G2_2022_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tractor miTractor = new Tractor("Chevrolet", "JILR", 78000);
            //hija.marca = "Nissan";
            miTractor.ImprimirPantalla();
            //Tractor miTractor = new Tractor();
            //Automovil miAutomovil = new Automovil();
            Automovil miAutomovil = new Automovil("FORD", "MSMDC", 250000);
            miAutomovil.ImprimirPantallaAutomovil();
            Console.ReadLine();

        }
    }
}
