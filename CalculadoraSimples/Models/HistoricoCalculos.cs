// Gerencia o histórico de operações: armazena as ultimas operações (limite de 4), fornece acesso ao histórico e limpa o histórico

public class HistoricoCalculos
{
    private readonly Queue<string> _historico = new Queue<string>();
    private const int CapacidadeMaxima = 4;

    public void Adicionar(string operacao)
    {
        if (_historico.Count >= CapacidadeMaxima)
        {
            _historico.Dequeue();
        }
        _historico.Enqueue(operacao);
    }

    public IEnumerable<string> ObterTodos() => _historico.ToList();

    public void Limpar() => _historico.Clear();
}