using PlataformaCurso.Models;

public class ProfessorService
{
    private List<Professor> ListaDeProfessores = new List<Professor>();

    public void IniciarCadastro()
    {
        Professor novoProfessor;

        Console.WriteLine("Digite o nome do professor");
        var nome = Console.ReadLine();

        if (!string.IsNullOrEmpty(nome))
        {
            novoProfessor = new Professor(nome);

            Console.WriteLine("Digite as áreas de atuação separado por vírgula (SÓ APERTE ENTER QUANDO ACABAR)");
            var conhecimentos = Console.ReadLine();

            novoProfessor.Conhecimentos = conhecimentos?.Split(",").ToList() ?? new List<string>();
            ListaDeProfessores.Add(novoProfessor);

            Console.WriteLine("Professor cadastrado com sucesso!");
        }
    }

    public List<Professor> ObterTodos()
    {
        return this.ListaDeProfessores;
    }
}