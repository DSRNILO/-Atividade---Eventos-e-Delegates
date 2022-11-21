using PlataformaCurso.Models;

public class ExtesnsaoService
{
    private List<Extensao> ListaDeExtensao = new List<Extensao>();

    public void CriarExtensao(List<Professor> professoresPossiveis)
    {
        Extensao novaExtensao;

        Console.WriteLine("Digite o nome da extensão");
        var nome = Console.ReadLine();

        if (!string.IsNullOrEmpty(nome))
        {
            var professorResponsavel = SelecionaProfessorResponsavel(professoresPossiveis);

            novaExtensao = new Extensao(nome, professorResponsavel);
            Console.WriteLine("Extensão cadastrada com sucesso!");
        }
    }

    private Professor? SelecionaProfessorResponsavel(List<Professor> professores)
    {
        Console.WriteLine("Escolha o professor responsável (SELECIONE A OPÇÂO)");

        for(int i = 0; i < professores.Count; i++) {
            Console.WriteLine($"{i+1} - {professores[i].Nome}");
        }

        var textoDigitado = Console.ReadLine();

        if(!string.IsNullOrEmpty(textoDigitado))
        {
            var indice = int.Parse(textoDigitado) - 1;
            return professores[indice];
        }

        return null;
    }

    public List<Extensao> ObterTodos()
    {
        return this.ListaDeExtensao;
    }
}