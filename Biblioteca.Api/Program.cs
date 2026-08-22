

using Biblioteca.Api;
using Biblioteca.Dominio;

var builder = WebApplication.CreateBuilder(args);
var api = builder.Build();

var acervo = new Acervo();
var cadastro = new Cadastro();
Seed.Popular(acervo, cadastro);

api.MapGet("/itens", () => acervo.Itens);
api.MapGet("/", () => Results.Redirect("/itens"));



api.Run();
