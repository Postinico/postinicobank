using postinico_bank.Enums;
using postinico_bank.Interfaces;

namespace postinico_bank.Cartoes
{
    public class CartaoDuke : ICartao
    {
        public bool ObterTipo(TipoCartao tipo) => tipo == TipoCartao.Duke;

        public void Debitar(decimal valor)
        {
            Console.WriteLine($"[ODUKE] Débito de R$ {valor:F2} realizado com sucesso.");
        }

        public void Creditar(decimal valor)
        {
            Console.WriteLine($"[ODUKE] Crédito de R$ {valor:F2} adicionado à fatura.");
        }
    }
}
