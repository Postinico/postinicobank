using postinico_bank.Enums;
using postinico_bank.Interfaces;

namespace postinico_bank.Cartoes
{
    public class CartaoPlatinum : ICartao
    {
        public decimal CashbackPercentual => 0.02m;

        public bool ObterTipo(TipoCartao tipo) => tipo == TipoCartao.Platinum;

        public void Debitar(decimal valor)
        {
            Console.WriteLine($"[Platinum] Débito de R$ {valor:F2} realizado com sucesso.");
        }

        public void Creditar(decimal valor)
        {
            decimal cashbackCalculado = valor * CashbackPercentual;
            Console.WriteLine($"[Platinum] Débito de R$ {valor:F2} | Cashback gerado: R$ {cashbackCalculado:F2}");
        }
    }
}
