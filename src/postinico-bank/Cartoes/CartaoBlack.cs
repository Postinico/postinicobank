using postinico_bank.Enums;
using postinico_bank.Interfaces;

namespace postinico_bank.Cartoes
{
    public class CartaoBlack : ICartao
    {
        public decimal CashbackPercentual => 0.01m;

        public bool ObterTipo(TipoCartao tipo) => tipo == TipoCartao.Black;

        public void Debitar(decimal valor)
        {
            Console.WriteLine($"[BLACK] Débito de R$ {valor:F2} realizado com sucesso.");
        }

        public void Creditar(decimal valor)
        {
            decimal cashbackCalculado = valor * CashbackPercentual;
            Console.WriteLine($"[BLACK] Débito de R$ {valor:F2} | Cashback gerado: R$ {cashbackCalculado:F2}");
        }
    }
}
