namespace Biblioteca.Dominio;



public record Leitor(string Nome, DateTime DataNascimento)
{

    private static int _proximoLeitorId = 1;

        public int LeitorId { get; } = _proximoLeitorId++;

    

    public int Idade
    {
        get
        {
            var hoje = DateTime.Today;
            var idade = hoje.Year - DataNascimento.Year;
            if (DataNascimento > hoje.AddYears(-idade)) idade--;
            return idade;
        }
    }
}
