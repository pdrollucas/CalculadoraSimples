// Orquestra o fluxo da aplicação: recebe inputs da View, chama os métodos do Service, passa os dados para a View exibir, controla o fluxo do programa (menu principal)

public class CalculadoraController
{
    private readonly ICalculadoraService _calculadoraService;
    private readonly CalculadoraView _view;

    public CalculadoraController(ICalculadoraService calculadoraService, CalculadoraView view)
    {
        _calculadoraService = calculadoraService;
        _view = view;
    }

    public void Iniciar()
    {
        while (true)
        {
            _view.MostrarMenu();
            var opcao = _view.LerOpcao();

            if (opcao == "0") break;

            switch (opcao)
            {
                case "1":
                    RealizarCalculo();
                    break;
                case "2":
                    MostrarHistorico();
                    break;
                case "3":
                    LimparHistorico();
                    break;
                default:
                    _view.MostrarMensagem("Opção inválida!");
                    break;
            }
        }
    }

    private void RealizarCalculo()
    {
        try
        {
            var (num1, num2, operacao) = _view.LerDadosCalculo();
            var resultado = _calculadoraService.Calcular(num1, num2, operacao);
            _view.MostrarResultado(resultado);
        }
        catch (Exception ex)
        {
            _view.MostrarErro(ex.Message);
        }
    }

    private void MostrarHistorico()
    {
        var historico = _calculadoraService.ObterHistorico();
        _view.MostrarHistorico(historico);
    }

    private void LimparHistorico()
    {
        _calculadoraService.LimparHistorico();
        _view.MostrarMensagem("Histórico limpo com sucesso!");
    }
}