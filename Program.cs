using System.Globalization;
using ConsoleApp2.Models;

Pessoa p1 = new Pessoa(name:"Breno", lastname:"Marcomini");
Pessoa p2 = new Pessoa("Julia" , "Marchetti");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Name = "Curso de Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
//cursoDeIngles.ListarAlunos();

decimal valorMonetário = 82.40m;
//Console.WriteLine(valorMonetário.ToString("C", CultureInfo.CreateSpecificCulture("PT-BR")));

try
{
    string[] linhas = File.ReadAllLines("../../../Arquivos/texto.txt");
    foreach (var linha in linhas)
    {
        //Console.WriteLine(linha);
    }
}
catch (Exception e)
{
    //Console.WriteLine($"Ocorreu uma execeção ao ler o arquivo {e.Message}");

}
finally
{
    //Console.WriteLine($"Chegou até aqui!");
}

//new ExemploExcecao().method1();




Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);
fila.Enqueue(10);

foreach (var item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); // remove o primeiro elemento da fila

foreach (var item in fila)
{
    Console.WriteLine(item);
}

//Pessoa p1 = new Pessoa();
//p1.Name = "Breno";
//p1.Age = 33;
//p1.LastName = "Marcomini";
//p1.Apresentar();