using BLL.Interfaces;

namespace BLL.Strategies
{
    public class GroundShippingStrategy : IShippingStrategy
    {
        //Implementa el cálculo del envío terrestre
        public decimal CalculateCost(decimal baseCost)
        {
            return baseCost + 2000m;
        }
    }
}
