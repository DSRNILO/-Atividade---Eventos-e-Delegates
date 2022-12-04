namespace PlataformaCurso.Models;

public class Materia {
    public string Nome { get; set; }
    public List<Aluno> Alunos { get; set; } = new List<Aluno>();
    public Professor? ProfessorResponsavel { get; set; }

    public Materia(string nome, Professor? professorResponsavel)
    {
        this.Nome = nome;

        if(professorResponsavel?.ValidaSeSabeConhecimento(nome) ?? false)
        {
            this.ProfessorResponsavel = professorResponsavel;
        }
        else
        {
            Console.WriteLine("Professor não está apto para ministrar esta matéria");
            this.ProfessorResponsavel = null;
        }
    }

    public bool MatricularAluno(Aluno aluno)
    {
        if(!aluno.TemPendenciaFinanceira && this.Alunos.Count < 50) {
            this.Alunos.Add(aluno);
            return true;
        }

        return false;
    }
}