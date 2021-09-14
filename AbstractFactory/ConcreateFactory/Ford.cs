using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactory.Product;

namespace AbstractFactory.ConcreateFactory
{
    public class Ford : AbstractFactoryCar
    {
        public override CarOld CriarCarroAntigo()
        {
            return new EscortOld();
        }

        public override CarNew CriarCarroNovo()
        {
            return new FusionNew();
        }
    }
}
