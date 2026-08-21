 using Biblioteca.Dominio;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

ItemAcervo Livro = new Livro("Pikinu Principi", "jucinto");

app.MapGet("/", () => "Hello World!");


app.Run();
