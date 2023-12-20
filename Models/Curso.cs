namespace ConsoleApp2.Models;

public class Curso
{
    public string Name { get; set; }
    public List<Pessoa> Alunos { get; set; }
    public void AdicionarAluno(Pessoa aluno) // aluno é um objeto do tipo Pessoa, que é uma classe que criamos. aluno é um parâmetro do tipo Pessoa, nome da variavel
    {
        Alunos.Add(aluno);
    }
    public void RemoverAluno(Pessoa aluno)
    {
        Alunos.Remove(aluno);
    } 
    public int ObterQuantidadeAlunos()
    {
        return Alunos.Count;
    }
    public void ListarAlunos()
    {
        Console.WriteLine($"Alunos do curso de : {Name}");
        for(int count = 0; count < Alunos.Count; count++)
        {
            Console.WriteLine($"{count + 1} - {Alunos[count].FullName}");
        }
    }
}