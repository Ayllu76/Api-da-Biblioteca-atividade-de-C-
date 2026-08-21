namespace Biblioteca.Api;
using Biblioteca.Dominio;
public static class Seed
{
    public static void Popular(Acervo acervo, Cadastro cadastro)
    {
        acervo.AdicionarItem(new Livro("Dom Casmurro", "Machado de Assis"));
        acervo.AdicionarItem(new Livro("Vidas Secas", "Graciliano Ramos"));
        acervo.AdicionarItem(new Revista("Superinteressante", "Editora Abril"));
        acervo.AdicionarItem(new Dvd("Toy Story", "John Lasseter", 0));
        acervo.AdicionarItem(new Dvd("Cidade de Deus", "Fernando Meirelles", 16));

        cadastro.AdicionarItem(new Leitor
        ("Marina", DateTime.Today.AddYears(-15)));
        cadastro.AdicionarItem(new Leitor
        ("Caio", DateTime.Today.AddYears(-30)));
    }
}