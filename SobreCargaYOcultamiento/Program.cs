using SobreCargaYOcultamiento;
using System;

public class Program 
{
    static void Main(string[]args)
    {

        Console.WriteLine("Hola, Cliente!");

        Vehiculo MiAuto = new Coche();
        MiAuto.RealizarMantenimiento();  //Realizando mantenimiento del coche 
        Console.WriteLine("Costo del mantenimiento del coche: $" + MiAuto.ObtenerCostoMantenimiento());
        


        Vehiculo Motocicleta = new Moto();
        Motocicleta.RealizarMantenimiento(); //Realizando mantenimiento de la moto 
        Console.WriteLine("Costo del mantenimiento de la Moto: $" + Motocicleta.ObtenerCostoMantenimiento());


        //Ejercer metodo para lavar el coche 

        MiAuto.LavarV();
        Coche MiAutoReal = new Coche();
        MiAutoReal.LavarV();

        Servicio ServAceite = new CambioDeAceite();
        ServAceite.RealizarServicio();
        Console.WriteLine("Costo del cambio de aceite: $" + ServAceite.CalcularCosto());

        int TiempoCambioAceite = ServAceite.CalcularTiempoTTServicio();
        Console.WriteLine("Tiempo total para el cambio de aceite fue de: " + TiempoCambioAceite + "Horas");



        Servicio ServFrenos = new ReparacionDeFrenos();
        ServFrenos.RealizarServicio();
        Console.WriteLine("Costo del cambio de frenos: $" + ServFrenos.CalcularCosto());

        int TiempoFrenos = ServFrenos.CalcularTiempoTTServicio();
        Console.WriteLine("Tiempo total para el servicio de reparacion de frenos: " + TiempoFrenos +"Horas" );

        /* Servicio Ser = new Servicio(); */


    }



}