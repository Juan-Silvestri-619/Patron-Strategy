namespace DOMAIN
{
    public class Shipment
    {
        public decimal BaseCost { get; private set; }

        //Nos permite establecer un costo base al crear el objeto
        public Shipment(decimal baseCost)
        {
            BaseCost = baseCost;
        }
    }
}
