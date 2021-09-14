using System;
using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractProduct;
using AbstractFactory.ConcreateFactory;

namespace AbstractFactory.Client
{
    public class CarroClient
    {
        CarNew carNew;
        CarOld carOld;
        public CarroClient(AbstractFactoryCar carFactory)
        {
            carNew = carFactory.CriarCarroNovo();
            carOld = carFactory.CriarCarroAntigo();
        }

        public string BuscarCarroNovoDetalhes()
        {
            return carNew.DetalhesCarroNovo();
        }

        public string BuscarCarroAntigoDetalhes()
        {
            return carOld.DetalhesCarroAntigo();
        }

        public static CarroClient CriarCarro(string marca)
        {
            switch (marca)
            {
                case "Ford":
                    return new CarroClient(new Ford());
                case "GM":
                    return new CarroClient(new GM());                
                default:
                    throw new ApplicationException("Não foi possível identificar a marca");
            }
        }
    }
}
