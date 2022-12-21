namespace DesafioProjetoHospedagem.Models
{
  public class Reserva
  {
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados)
    {
      DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
      if (Suite.Capacidade >= hospedes.Count)
      {
        if (hospedes.Count <= 0)
        {
          Console.WriteLine("Quantidade de hóspedes não pode ser menor que 1! Por favor digite novamente.");

        }
        Hospedes = hospedes;
      }
      else
      {
        throw new ArgumentException($"Quantidade de hóspedes maior que a capacidade da suíte! Por favor verifique novamente.");
      }
    }

    public void CadastrarSuite(Suite suite)
    {
      Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
      return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
      decimal desconto;
      decimal valorFinal = DiasReservados * Suite.ValorDiaria;

      if (DiasReservados >= 10)
      {
        desconto = valorFinal * 0.1M;
        valorFinal = valorFinal - desconto;
      }
      return valorFinal;
    }
  }
}