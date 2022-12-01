using PlataformaCurso.Models;

public class MateriaService
{
////////////////////////////////////////////////////////////////////////////////
 public delegate void MateriaCriadaEventHandler(object source , EventArgs args);

public event MateriaCriadaEventHandler MateriaCriada;


    public void newmateria(Materia  materia)
    {
        Console.WriteLine("Materia sendo adicionada.....");
        Thread.Sleep(3000); // Simular uma demora de 3s

        implementarmateria(materia);
    }

    protected virtual void implementarmateria(Materia materia)
    {
        if (MateriaCriada != null)
        {
            var args = new materiaEventArgs() { materia = materia };
            MateriaCriada(this, args);
        }
    }

////////////////////////////////////////////////////////////////////////////////
    private List<Materia> ListaDeMaterias = new List<Materia>();

    public void CriarMateria(List<Professor> professoresPossiveis)
    {
        Materia novaMateria;

        Console.WriteLine("Digite o nome da matéria");
        var nome = Console.ReadLine();

        if (!string.IsNullOrEmpty(nome))
        {
            var professorResponsavel = SelecionaProfessorResponsavel(professoresPossiveis);
            
            novaMateria = new Materia(nome, professorResponsavel);
            newmateria; 
            Console.WriteLine("Materia cadastrada com sucesso!");
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

    public List<Materia> ObterTodos()
    {
        return this.ListaDeMaterias;
    }
}