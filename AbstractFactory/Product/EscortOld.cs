using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Product
{
    public class EscortOld : CarOld
    {
        public EscortOld()
        {
            Carro = "Ford Escorte ano 1985";
        }

        public override string DetalhesCarroAntigo()
        {
            return Carro;
        }
    }
}
