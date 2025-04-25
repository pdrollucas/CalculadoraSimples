// Contém as implementações das operações básicas e valida regras matemáticas

public static class OperacoesMatematicas
{
    public static double Somar(double a, double b) => a + b;
    public static double Subtrair(double a, double b) => a - b;
    public static double Multiplicar(double a, double b) => a * b;

    public static double Dividir(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Divisão por zero não é permitida.");
        return a / b;
    }
}