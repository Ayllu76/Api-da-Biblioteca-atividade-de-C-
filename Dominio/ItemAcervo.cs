namespace Biblioteca.Dominio;

public abstract  class ItemAcervo
{
  protected ItemAcervo(string titulo, string autor)
  {
    if(string.IsNullOrWhiteSpace((titulo)))
    { 
    throw new ExececaoDominio("O titulo é obrigatorio :)");
    }

    Titulo = titulo;
    Autor = autor;
    
  }
  public string Titulo { get; private set; }  = string.Empty;
   public string  Autor { get; private set; }  = string.Empty;

   public bool Disponibilidade { get; private set; }  = true;

   public abstract int PracoDevolucao {get;}
   public abstract decimal MultaDiaAtrasado {get;}

   public decimal CalcularMulta(int diasAtrasados) {
    
    return diasAtrasados >= 0 ? diasAtrasados * MultaDiaAtrasado : 0;
   } 
  
  public void MarcarComoDevolvido()
  {
    if(Disponibilidade)
    {
      throw new ExececaoDominio("O item já está disponível para empréstimo");
    }
    Disponibilidade = true;
  }
  public void MarcarComoEmprestado()
  {
    if(!Disponibilidade)
    {
      throw new ExececaoDominio("O item não está disponível para empréstimo");
    }
    Disponibilidade = false;
  }

}