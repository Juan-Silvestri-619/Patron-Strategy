using BLL.Interfaces;
using DOMAIN;

namespace BLL.Services
{
    public class ShippingService
    {
        private readonly IShippingStrategy _strategy;
        //ShippingService no necesita saber si está calculando si es terrestre o aéreo 
        //el envío. Solo necesita recibir una estrategía que implemente IShippingStrategy
        public ShippingService(IShippingStrategy strategy)
        {
            _strategy = strategy;
        }
        //Calculate nos devuelve el cálculo realizado del costo base y su adicional
        public decimal Calculate(Shipment shipment)
        {
            return _strategy.CalculateCost(shipment.BaseCost);
        }
    }
}
