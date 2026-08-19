using postinico_bank.Enums;
using postinico_bank.Interfaces;
using System.Reflection;

namespace postinico_bank.Factories
{
    public class CartaoFactory
    {
        public static ICartao CriarCartao(TipoCartao tipoDesejado)
        {
            var tiposDeCartao = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(ICartao).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract);

            ICartao cartaoEncontrado = tiposDeCartao
                .Select(tipo => Activator.CreateInstance(tipo) as ICartao)
                .FirstOrDefault(instancia => instancia != null && instancia.ObterTipo(tipoDesejado));

            return cartaoEncontrado ?? throw new ArgumentException($"Nenhum cartão encontrado para o tipo: {tipoDesejado}");
        }
    }
}
