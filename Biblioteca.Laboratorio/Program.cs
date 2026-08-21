using System.Linq.Expressions;
using Biblioteca.Dominio;


var marina = new Leitor("Marina", new DateTime(2013, 1, 1));
var dvd = new Dvd("O Senhor dos Anéis", "J.R.R. Tolkien", 16);


try
{
    var emprestimo2 = new Emprestimo(marina, dvd);
}
catch (ExececaoDominio ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}


var caio = new Leitor("Caio", new DateTime(2005, 2, 3));
var dvd1 = new Dvd("Coringa", "J.R.R. Tolkien", 16);
var dvd2 = new Dvd("Animals", "J.R.R. Tolkien", 16);
var livro = new Livro("Memorias postumas", "Machado de Assis");
var dvd3 = new Dvd("vacalo english", "chicu buarqui", 10);

var emprestimo3 = new Emprestimo(caio, dvd1);
var emprestimo4 = new Emprestimo(caio, dvd2);
var emprestimo5 = new Emprestimo(caio, livro);



emprestimo5.RegistrarDevolucao();

Console.WriteLine($"Empréstimo devolvido. Multa: {emprestimo5.ValorMultaAtual}");

try
{

    new Emprestimo(caio, dvd3);
    Console.WriteLine("Empréstimo realizado com sucesso.");


}
catch (ExececaoDominio ex)
{

    Console.WriteLine($"Erro: {ex.Message}");

}


var julia = new Leitor("Julia", new DateTime(2010, 5, 10));
var livro2 = new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry");
var emprestimo6 = new Emprestimo(julia, livro2);

try
{
    var emprestimo7 = new Emprestimo(julia, livro2);
    Console.WriteLine("Empréstimo realizado com sucesso.");
}


catch (ExececaoDominio ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}



var leitor = new Leitor("Elias", new DateTime(2008, 3, 15));
var livro8 = new Revista("1984", "George Orwell");


var emprestimo8 = new Emprestimo(leitor, livro8);
emprestimo8.RegistrarDevolucao();

try
{
    emprestimo8.RegistrarDevolucao();
    var teste = emprestimo8.ValorMultaAtual;
    Console.WriteLine($"Empréstimo devolvido. Multa: {teste}");

}
catch (ExececaoDominio ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}


var livroNovo = new Livro("O Cortiço", "Aluísio Azevedo");
var revistaNova = new Revista("Piauí", "Alvinegra");
Console.WriteLine($"Cena 6 - {livroNovo.Titulo} e o Id {livroNovo.Id}, " +
                  $"{revistaNova.Titulo} e o Id {revistaNova.Id}");




var Leitor = new Leitor("Carlos", new DateTime(2000, 1, 1));
var Leitor1 = new  Leitor("Maria", new DateTime(2005, 2, 3));
Console.WriteLine($"Cena 7 - {Leitor.Nome} e o Id {Leitor.LeitorId}, " +
                  $"{Leitor1.Nome} e o Id {Leitor1.LeitorId}");