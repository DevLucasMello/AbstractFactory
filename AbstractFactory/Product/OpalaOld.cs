using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Product
{
    public class OpalaOld : CarOld
    {
        public OpalaOld()
        {
            Carro = "GM Opala ano 1980";
        }

        public override string DetalhesCarroAntigo()
        {
            return Carro;
        }
    }
}
