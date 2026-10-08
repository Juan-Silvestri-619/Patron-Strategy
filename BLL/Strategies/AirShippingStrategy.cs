using BLL.Interfaces;

namespace BLL.Strategies
{
    //Implementa el cálculo del envío aéreo
    public class AirShippingStrategy : IShippingStrategy
    {
        public decimal CalculateCost(decimal baseCost)
        {
            return baseCost + 5000m;
        }
    }
}
