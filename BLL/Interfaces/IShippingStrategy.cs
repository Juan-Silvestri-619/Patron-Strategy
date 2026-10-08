namespace BLL.Interfaces
{
    public interface IShippingStrategy
    {
        //Aquí va el método que deben implementar todas las estrategias de envío
        //Representa el contrato que deben cumplir las estrategias
        decimal CalculateCost(decimal baseCost);
    }
}
