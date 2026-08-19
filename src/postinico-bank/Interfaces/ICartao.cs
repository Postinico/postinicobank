using postinico_bank.Enums;

namespace postinico_bank.Interfaces
{
    public interface ICartao
    {
        bool ObterTipo(TipoCartao tipo);
        void Debitar(decimal valor);
        void Creditar(decimal valor);
    }
}
