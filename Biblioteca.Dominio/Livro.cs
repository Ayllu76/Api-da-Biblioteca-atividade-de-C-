namespace Biblioteca.Dominio;

public class Livro(string titulo, string autor) : ItemAcervo(titulo, autor)
{

    public override int PracoDevolucao => 14;
    public override decimal MultaDiaAtrasado  =>  1m;
}