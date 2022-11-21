namespace PlataformaCurso.Models;

public class Curso {
    public string Nome { get; set; }
    public List<Materia> Materias { get; set; } = new List<Materia>();
    public Coordenador? Coordenador { get; set; }

    public Curso(string nome, Coordenador coordenador)
    {
        this.Nome = nome;

        if(coordenador.ValidaSeSabeConhecimento(nome))
        {
            this.Coordenador = coordenador;
        }
        else
        {
            this.Coordenador = null;
        }
    }

    public void AdicionarMateria(Materia materia) {
        Materias.Add(materia);
        Materias.Add(materia);
    }
}