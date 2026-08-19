using postinico_bank.Enums;
using postinico_bank.Interfaces;

namespace postinico_bank.Cartoes
{
    public class CartaoDuke : ICartao
    {
        public decimal CashbackPercentual => 0.1m;

        public bool ObterTipo(TipoCartao tipo) => tipo == TipoCartao.Duke;

        public void Debitar(decimal valor)
        {
            Console.WriteLine($"[ODUKE] Débito de R$ {valor:F2} realizado com sucesso.");
        }

        public void Creditar(decimal valor)
        {
            decimal cashbackCalculado = valor * CashbackPercentual;
            Console.WriteLine($"[ODUKE] Credito de R$ {valor:F2} | Cashback gerado: R$ {cashbackCalculado:F2}");
        }
    }
}
