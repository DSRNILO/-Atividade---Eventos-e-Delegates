namespace PlataformaCurso.Models;

public class Extensao
{
    public string Nome { get; set; }
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();
    public Professor? ProfessorResponsavel { get; set; }

    public Extensao(string nome, Professor? professorResponsavel)
    {
        this.Nome = nome;

        if (professorResponsavel?.ValidaSeSabeConhecimento(nome) ?? false)
        {
            this.ProfessorResponsavel = professorResponsavel;
        }
        else
        {
            Console.WriteLine("Professor não é apto para ministrar esta extensão");
            this.ProfessorResponsavel = null;
        }
    }

    public bool MatricularAluno(Aluno aluno)
    {
        if (this.Alunos.Count < 100)
        {
            this.Alunos.Add(aluno);
            return true;
        }

        return false;
    }
}