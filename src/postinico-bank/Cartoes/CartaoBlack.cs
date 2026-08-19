using postinico_bank.Enums;
using postinico_bank.Interfaces;

namespace postinico_bank.Cartoes
{
    public class CartaoBlack : ICartao
    {
        public bool ObterTipo(TipoCartao tipo) => tipo == TipoCartao.Black;

        public void Debitar(decimal valor)
        {
            Console.WriteLine($"[BLACK] Débito de R$ {valor:F2} realizado com sucesso.");
        }

        public void Creditar(decimal valor)
        {
            Console.WriteLine($"[BLACK] Crédito de R$ {valor:F2} adicionado à fatura.");
        }
    }
}
