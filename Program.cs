﻿using System.Globalization;
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

string[] linhas = File.ReadAllLines("../../../Arquivos/texto.txt");
foreach (var linha in linhas)
{
    Console.WriteLine(linha);
}


//Pessoa p1 = new Pessoa();
//p1.Name = "Breno";
//p1.Age = 33;
//p1.LastName = "Marcomini";
//p1.Apresentar();