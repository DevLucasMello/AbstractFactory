using AbstractFactory.AbstractProduct;

namespace AbstractFactory.Product
{
    public class OnixNew : CarNew
    {
        public OnixNew()
        {
            Carro = "GM Onix ano 2020";
        }

        public override string DetalhesCarroNovo()
        {
            return Carro;
        }
    }
}
