using PlataformaCurso.Models;

public class CoordenadorService
{
    private List<Coordenador> ListaDeCoordenador = new List<Coordenador>();

    public void IniciarCadastro()
    {
        Coordenador novoCoordenador;

        Console.WriteLine("Digite o nome do coordenador");
        var nome = Console.ReadLine();

        if (!string.IsNullOrEmpty(nome))
        {
            novoCoordenador = new Coordenador(nome);

            Console.WriteLine("Digite as áreas de atuação separado por vírgula (SÓ APERTE ENTER QUANDO ACABAR)");
            var conhecimentos = Console.ReadLine();

            novoCoordenador.Conhecimentos = conhecimentos?.Split(",").ToList() ?? new List<string>();
            ListaDeCoordenador.Add(novoCoordenador);

            Console.WriteLine("Coordenador cadastrado com sucesso!");
        }
    }

    public List<Coordenador> ObterTodos()
    {
        return this.ListaDeCoordenador;
    }
}