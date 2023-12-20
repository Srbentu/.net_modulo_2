namespace ConsoleApp2.Models;

public class ExemploExcecao
{
    public void method1()
    {
        try
        {
            method2();
        }
        catch (Exception)
        {
            Console.WriteLine("Execução do método 1 interrompida");
        }
    }
    public void method2()
    {
        method3();
    }
    public void method3()
    {
        method4();
    }
    public void method4()
    {
        throw new Exception("Ocorreu um erro ");
    }
}