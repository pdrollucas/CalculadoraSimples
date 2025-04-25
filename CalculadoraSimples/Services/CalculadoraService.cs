// Lógica de negócio principal: executa os cálculos, gerencia o histórico através do model, valida operações, implementa a interface de serviço

public class CalculadoraService : ICalculadoraService
{
    private readonly HistoricoCalculos _historico;

    public CalculadoraService(HistoricoCalculos historico)
    {
        _historico = historico;
    }

    public double Calcular(double num1, double num2, string operacao)
    {
        double resultado;

        switch (operacao)
        {
            case "+":
                resultado = OperacoesMatematicas.Somar(num1, num2);
                break;
            case "-":
                resultado = OperacoesMatematicas.Subtrair(num1, num2);
                break;
            case "*":
                resultado = OperacoesMatematicas.Multiplicar(num1, num2);
                break;
            case "/":
                resultado = OperacoesMatematicas.Dividir(num1, num2);
                break;
            default:
                throw new ArgumentException("Operação inválida");
        }

        _historico.Adicionar($"{num1} {operacao} {num2} = {resultado}");
        return resultado;
    }

    public IEnumerable<string> ObterHistorico() => _historico.ObterTodos();

    public void LimparHistorico() => _historico.Limpar();
}