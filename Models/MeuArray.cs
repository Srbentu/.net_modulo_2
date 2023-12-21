namespace ConsoleApp2.Models;

public class MeuArray <T>
{
    private static int capacidade = 10;
    private T[] array = new T[capacidade];
    private int contador = 0;

    public void adicionarElementoArray(T element)
    {
        if (contador + 1 < 11)
        {
            array[contador] = element;
        }
        contador++;
    }

    public T this[int index]
    {
        get{return array[index];}
        set { array[index] = value; }
    }
}