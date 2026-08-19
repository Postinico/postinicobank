// See https://aka.ms/new-console-template for more information
using postinico_bank.Enums;
using postinico_bank.Factories;
using postinico_bank.Interfaces;

Console.WriteLine("Hello, Factory!\n");

Console.WriteLine("Escolha o tipo de cartão:");
Console.WriteLine("0 - Black");
Console.WriteLine("1 - Platinum");
Console.WriteLine("2 - Duke");
Console.Write("Digite o número ou nome do cartão: ");

string input = Console.ReadLine();

if (Enum.TryParse<TipoCartao>(input, true, out var tipoSelecionado))
{
    Console.WriteLine();

    ICartao cartao = CartaoFactory.CriarCartao(tipoSelecionado);

    Console.WriteLine($"Cartão instanciado com sucesso: {cartao.GetType().Name}");

    cartao.Debitar(5000.00m);
    cartao.Creditar(5000.00m);
}
else
{
    Console.WriteLine("\nOpção inválida!");
}

Console.WriteLine("\nPressione qualquer tecla para finalizar...");
Console.ReadKey();
