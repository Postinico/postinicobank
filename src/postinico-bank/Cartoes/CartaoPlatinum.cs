using postinico_bank.Enums;
using postinico_bank.Interfaces;

namespace postinico_bank.Cartoes
{
    public class CartaoPlatinum : ICartao
    {
        public bool ObterTipo(TipoCartao tipo) => tipo == TipoCartao.Platinum;

        public void Debitar(decimal valor)
        {
            Console.WriteLine($"[Platinum] Débito de R$ {valor:F2} realizado com sucesso.");
        }

        public void Creditar(decimal valor)
        {
            Console.WriteLine($"[Platinum] Crédito de R$ {valor:F2} adicionado à fatura.");
        }
    }
}
