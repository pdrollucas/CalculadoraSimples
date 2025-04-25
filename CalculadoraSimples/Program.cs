class Program
{
    static void Main()
    {
        // Configuração da injeção de dependência (simplificada)
        var historico = new HistoricoCalculos();
        var calculadoraService = new CalculadoraService(historico);
        var view = new CalculadoraView();
        var controller = new CalculadoraController(calculadoraService, view);

        // Iniciar aplicação
        controller.Iniciar();
    }
}