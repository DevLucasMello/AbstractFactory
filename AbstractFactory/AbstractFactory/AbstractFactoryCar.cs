using AbstractFactory.AbstractProduct;

namespace AbstractFactory.AbstractFactory
{
    public abstract class AbstractFactoryCar
    {
        public abstract CarNew CriarCarroNovo();
        public abstract CarOld CriarCarroAntigo();
    }
}
