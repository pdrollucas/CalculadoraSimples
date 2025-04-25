// Garantir que regras de negócio são aplicadas, testa unidades individuais de código  e verifica comportamentos esperados

using Moq; // Para mocking (opcional)

public class CalculadoraTests
{
    [Fact]
    public void Somar_DoisNumerosPositivos_RetornaSomaCorreta()
    {
        // Arrange
        var mockHistorico = new Mock<HistoricoCalculos>();
        var service = new CalculadoraService(mockHistorico.Object);

        // Act
        var resultado = service.Calcular(5, 3, "+");

        // Assert
        Assert.Equal(8, resultado);
    }

    [Theory]
    [InlineData(5, 3, 8)]
    [InlineData(-1, -1, -2)]
    [InlineData(0, 0, 0)]
    public void Somar_VariosNumeros_RetornaSomasCorretas(double a, double b, double esperado)
    {
        // Arrange
        var mockHistorico = new Mock<HistoricoCalculos>();
        var service = new CalculadoraService(mockHistorico.Object);

        // Act
        var resultado = service.Calcular(a, b, "+");

        // Assert
        Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void Dividir_PorZero_LancaExcecao()
    {
        // Arrange
        var mockHistorico = new Mock<HistoricoCalculos>();
        var service = new CalculadoraService(mockHistorico.Object);

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => service.Calcular(5, 0, "/"));
    }

    [Fact]
    public void Historico_AdicionarMaisQueCapacidade_RemoveMaisAntigo()
    {
        // Arrange
        var historico = new HistoricoCalculos();

        // Act
        historico.Adicionar("1 + 1 = 2");
        historico.Adicionar("2 + 2 = 4");
        historico.Adicionar("3 + 3 = 6");
        historico.Adicionar("4 + 4 = 8");
        historico.Adicionar("5 + 5 = 10"); // Deve remover o primeiro

        // Assert
        var itens = historico.ObterTodos().ToList();
        Assert.DoesNotContain("1 + 1 = 2", itens);
        Assert.Contains("5 + 5 = 10", itens);
        Assert.Equal(4, itens.Count);
    }
}