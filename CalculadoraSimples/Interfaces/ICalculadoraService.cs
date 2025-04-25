// Responsável pelo contrato dos serviços de cálculos: define quais operações a calculadora deve implementar

public interface ICalculadoraService
{
    double Calcular(double num1, double num2, string operacao);
    IEnumerable<string> ObterHistorico();
    void LimparHistorico();
}