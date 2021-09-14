using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactory.Product;

namespace AbstractFactory.ConcreateFactory
{
    public class GM : AbstractFactoryCar
    {
        public override CarOld CriarCarroAntigo()
        {
            return new OpalaOld();
        }

        public override CarNew CriarCarroNovo()
        {
            return new OnixNew();
        }
    }
}
