namespace Biblioteca.Dominio;


public class Emprestimo
{


    public Emprestimo(ItemAcervo item)
    {
        item.MarcarComoEmprestado();
        Item = item;
        PrazoLimite = DataEmprestimo.AddDays(item.PracoDevolucao);
    }
    public ItemAcervo Item { get; }

    public DateTime DataEmprestimo { get; private set; } = DateTime.Today;

    public DateTime PrazoLimite { get; }
    public int QuantidadeDiaAtrasado
    {
        get
        {
            TimeSpan diasAtrasado = DateTime.Today - PrazoLimite;
            return diasAtrasado.Days;

        }
    }

    public void RegistrarDevolucao()
    {
        Item.MarcarComoDevolvido();
    }

}









