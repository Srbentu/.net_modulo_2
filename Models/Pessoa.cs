namespace ConsoleApp2.Models;

public class Pessoa
{
    private string _name;

    public string Name
    {
        get
        {
            return _name.ToUpper();
        }

        set
        {
            if (value == "")
            {
                throw new AggregateException("O nome não pode ser vazio");
            }

            _name = value;
        }
    }
    public int Age { get; set; }
    
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Name} e tenho {Age} anos.");
    }
}