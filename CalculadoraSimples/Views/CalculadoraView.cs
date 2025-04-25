// Responsável pela interface do usuário: mostrar menus e mensagens, ler entradas, formatar saídas, tratar erros de exibição

using System.Globalization;

public class CalculadoraView
{
    public void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("=== CALCULADORA ===");
        Console.WriteLine("1. Realizar cálculo");
        Console.WriteLine("2. Ver histórico");
        Console.WriteLine("3. Limpar histórico");
        Console.WriteLine("0. Sair");
        Console.Write("Opção: ");
    }

    public string LerOpcao() => Console.ReadLine();

    public (double num1, double num2, string operacao) LerDadosCalculo()
    {
        double LerNumero(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                var input = Console.ReadLine().Replace(",", "."); // caso o usuário digite uma vírgula, ela será substituída por um ponto. Assim, evitando erros de cálculo
                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out var numero))
                {
                    return numero;
                }
                Console.WriteLine("Número inválido. Tente novamente.");
            }
        }

        var num1 = LerNumero("Digite o primeiro número: ");

        Console.Write("Digite a operação (+, -, *, /): ");
        var operacao = Console.ReadLine();

        var num2 = LerNumero("Digite o segundo número: ");

        return (num1, num2, operacao);
    }

    public void MostrarResultado(double resultado)
    {
        Console.WriteLine($"Resultado: {resultado}");
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

    public void MostrarHistorico(IEnumerable<string> historico)
    {
        Console.WriteLine("=== HISTÓRICO ===");
        foreach (var item in historico)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

    public void MostrarMensagem(string mensagem)
    {
        Console.WriteLine(mensagem);
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

    public void MostrarErro(string mensagem)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Erro: {mensagem}");
        Console.ResetColor();
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
}