using Biblioteca.Dominio;
 namespace Biblioteca.Api;
 public class  Cadastro
    {
        private readonly List<Leitor> _itens = [];

        public IReadOnlyList<Leitor> Itens => _itens;

    
        public void AdicionarItem(Leitor leitor)
        {
            _itens.Add(leitor);
        }
    
        public Leitor? BuscarPorId(int id)
        {
            return _itens.FirstOrDefault(leitor => leitor.LeitorId == id);
        }
        }