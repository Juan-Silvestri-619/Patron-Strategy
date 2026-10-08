using BLL.Services;
using BLL.Strategies;
using DOMAIN;
using System;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Establezco un valor base de envío
            Shipment shipment = new Shipment(10000m);
            //Creo un servicio de envío y le inyecto la estrategia de envío terrestre
            ShippingService serviceGround = new ShippingService(new GroundShippingStrategy());
            ShippingService serviceAir = new ShippingService(new AirShippingStrategy());
            //Calculo el costo total utilizando la estrategia elegida
            decimal totalGround = serviceGround.Calculate(shipment);
            decimal totalAir = serviceAir.Calculate(shipment);

            Console.WriteLine($"Total ground: ${totalGround}");
            Console.WriteLine($"Total air: ${totalAir}");
        }
    }
}
