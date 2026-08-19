// See https://aka.ms/new-console-template for more information
using postinico_bank.Enums;
using postinico_bank.Factories;
using postinico_bank.Interfaces;

Console.WriteLine("Hello, Factory!\n");
bool continuar = true;

do
{
    Console.Clear();
    Console.WriteLine("=== Menu de Cartões ***POSTINICO BANK***===");
    Console.WriteLine("0 - Black");
    Console.WriteLine("1 - Platinum");
    Console.WriteLine("2 - Duke");
    Console.WriteLine("3 - Sair");
    Console.Write("Digite o número ou nome do cartão (ou 'sair'): ");

    string input = Console.ReadLine();

    if (input?.ToLower() == "3" || input?.ToLower() == "sair")
    {
        continuar = false;
        Console.WriteLine("\nEncerrando a aplicação...");
        break;
    }

    if (Enum.TryParse<TipoCartao>(input, true, out var tipoSelecionado))
    {
        Console.WriteLine();

        try
        {
            ICartao cartao = CartaoFactory.CriarCartao(tipoSelecionado);

            Console.WriteLine($"Cartão instanciado com sucesso: {cartao.GetType().Name}");

            cartao.Debitar(5000.00m);
            cartao.Creditar(5000.00m);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao criar cartão: {ex.Message}");
        }
    }
    else
    {
        Console.WriteLine("\nOpção inválida!");
    }

    Console.WriteLine("\nPressione qualquer tecla para continuar...");
    Console.ReadKey();

} while (continuar);
