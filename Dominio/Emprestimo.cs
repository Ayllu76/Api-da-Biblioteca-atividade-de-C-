namespace Biblioteca.Dominio;


public class Emprestimo
{
    // Mantém controle simples dos empréstimos criados para validações por leitor
    private static readonly List<Emprestimo> _registros = new();

    public Emprestimo(Leitor leitor, ItemAcervo item)
    {
        if (leitor is null) throw new ExececaoDominio("Leitor é obrigatório para emprestar");

        // valida idade mínima do item
        if (leitor.Idade < item.FaixaEtaria)
        {
            throw new ExececaoDominio("Leitor não possui idade mínima para este item");
        }

        // valida limite de empréstimos ativos (sem data de devolução)
        int ativosDoLeitor = _registros.Count(e => e.Leitor.Equals(leitor) && e.DataDevolucao == null);
        if (ativosDoLeitor >= 3)
        {
            throw new ExececaoDominio("O leitor já possui 3 empréstimos ativos");
        }

        
        Leitor = leitor;
        item.MarcarComoEmprestado();
        Item = item;
        DataEmprestimo = DateTime.Today;
        PrazoLimite = DataEmprestimo.AddDays(item.PracoDevolucao);

        // registra empréstimo como ativo
        _registros.Add(this);
    }

    public ItemAcervo Item { get; }

    public Leitor Leitor { get; }

    public DateTime DataEmprestimo { get; private set; } = DateTime.Today;

    public DateTime PrazoLimite { get; }

    public DateTime? DataDevolucao { get; private set; }

    public decimal ValorMultaPago { get; private set; }

    public int QuantidadeDiaAtrasado
    {
        get
        {
            TimeSpan diasAtrasado = DateTime.Today - PrazoLimite;
            return diasAtrasado.Days;

        }
    }

    // Retorna a multa atual: enquanto pendente calcula dinamicamente; após devolução retorna o valor congelado
    public decimal ValorMultaAtual
    {
        get
        {
            if (DataDevolucao != null) return ValorMultaPago;
            int dias = QuantidadeDiaAtrasado;
            return Item.CalcularMulta(dias);
        }
    }

    public void RegistrarDevolucao()
    {
        if (DataDevolucao != null)
        {
            return; // já devolvido
        }

        // calcula a multa no momento da devolução e grava no registro
        ValorMultaPago = ValorMultaAtual;
        DataDevolucao = DateTime.Today;

        Item.MarcarComoDevolvido();
    }


}









