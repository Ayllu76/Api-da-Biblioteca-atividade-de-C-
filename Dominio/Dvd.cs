namespace Biblioteca.Dominio;

public class Dvd(string titulo, string autor, int faixaEtaria) : ItemAcervo(titulo, autor)
{

    public override int PracoDevolucao => 3;
    public override decimal MultaDiaAtrasado  =>  3m;
    public override int FaixaEtaria => faixaEtaria;
}