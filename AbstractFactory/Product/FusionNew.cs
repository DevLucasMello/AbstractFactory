using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Product
{
    public class FusionNew : CarNew
    {
        public FusionNew()
        {
            Carro = "Ford Fusion ano 2021";
        }

        public override string DetalhesCarroNovo()
        {
            return Carro;
        }
    }
}
