namespace ConsoleApp2.Models;

public class LeituraArquivo
{
    public (bool Sucess, string[] Lines, int ManyLines) lerArquivo(string caminho)
    {
        try
        {
            string[] linhas = File.ReadAllLines(caminho);
            return (true, linhas, linhas.Length);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
           return (false, new string[0], 0);
        }
    }
}
