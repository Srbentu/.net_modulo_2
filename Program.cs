using System.Globalization;
using ConsoleApp2.Models;
using Newtonsoft.Json;


Venda v1 = new Venda(1, "Material de Escritório", 25.00M);

string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);
File.WriteAllText("../../../Arquivos/venda.json", serializado);














// Pessoa p4 = new Pessoa("Breno", "Marcomini");
// (string name, string lastname) = p4;
//
//
// Console.WriteLine($"{name}, {lastname}");
//















//
// (int id, string Name, string LastName) tupla = (1, "Breno", "Marcomini");
// ValueTuple<int, string, string> tupla2 = (1, "Breno", "Marcomini");
// var tupla3 = Tuple.Create(1, "Breno", "Marcomini");
//
// Console.WriteLine(tupla.Name);
// Console.WriteLine(tupla2.Item1);
// Console.WriteLine(tupla3.Item1);
//
//
//
//
//
//
// LeituraArquivo arquivo = new LeituraArquivo();
// var (Sucess, Lines, _) = arquivo.lerArquivo("../../../Arquivos/texto.txt");
// if(Sucess)
// {
//     //Console.WriteLine($"linhas lidas: {ManyLines}");
//     foreach (var line in Lines)
//     {
//         Console.WriteLine(line);
//     }
// }
// else
// {
//     Console.WriteLine("Ocorreu um erro ao ler o arquivo");
// }
//
// Pessoa p1 = new Pessoa(name:"Breno", lastname:"Marcomini");
// Pessoa p2 = new Pessoa("Julia" , "Marchetti");
//
// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Name = "Curso de Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// //cursoDeIngles.ListarAlunos();
//
// decimal valorMonetário = 82.40m;
// //Console.WriteLine(valorMonetário.ToString("C", CultureInfo.CreateSpecificCulture("PT-BR")));
//
// try
// {
//     string[] linhas = File.ReadAllLines("../../../Arquivos/texto.txt");
//     foreach (var linha in linhas)
//     {
//         //Console.WriteLine(linha);
//     }
// }
// catch (Exception e)
// {
//     //Console.WriteLine($"Ocorreu uma execeção ao ler o arquivo {e.Message}");
//
// }
// finally
// {
//     //Console.WriteLine($"Chegou até aqui!");
// }
//
// //new ExemploExcecao().method1();
//
// Dictionary<string, string> estados = new Dictionary<string, string>();
// estados.Add("SP", "São Paulo");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("MG", "Minas Gerais");
// estados.Add("ES", "Espírito Santo");
// estados.Add("PR", "Paraná");
// estados.Add("SC", "Santa Catarina");
// estados.Add("RS", "Rio Grande do Sul");
// estados.Add("GO", "Goiás");
// estados.Add("MT", "Mato Grosso");
//
// foreach (var estado in estados)
// {
//  Console.WriteLine($"{estado.Key} {estado.Value}");   
// }
//
// // Queue<int> fila = new Queue<int>();
// // fila.Enqueue(2);
// // fila.Enqueue(4);
// // fila.Enqueue(6);
// // fila.Enqueue(8);
// // fila.Enqueue(10);
// //
// // foreach (var item in fila)
// // {
// //     Console.WriteLine(item);
// // }
// //
// // Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); // remove o primeiro elemento da fila
// //
// // foreach (var item in fila)
// // {
// //     Console.WriteLine(item);
// // }
//
// //Pessoa p1 = new Pessoa();
// //p1.Name = "Breno";
// //p1.Age = 33;
// //p1.LastName = "Marcomini";
// //p1.Apresentar();