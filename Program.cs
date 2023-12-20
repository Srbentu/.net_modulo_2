using ConsoleApp2.Models;

Pessoa p1 = new Pessoa("Breno", "Marcomini");
Pessoa p2 = new Pessoa("Julia" , "Marchetti");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Name = "Curso de Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();


//Pessoa p1 = new Pessoa();
//p1.Name = "Breno";
//p1.Age = 33;
//p1.LastName = "Marcomini";
//p1.Apresentar();