namespace ConsoleApp2.Models;

public class Pessoa
{
    private string _name;
    private int _age;

    public string LastName { get; set; }
    public string Name
    {
        get => _name.ToUpper();
        

        set
        {
            if (value == "")
            {
                throw new AggregateException("O nome não pode ser vazio");
            }

            _name = value;
        }
    }

    public string FullName =>$"{Name} {LastName}".ToUpper(); 
    public int Age
    {
        get => _age;

        set
        {
            if (value < 0)
            {
                throw new AggregateException("Idade não pode ser menor que 0");
            }
 
            _age = value;
        }
    }
    
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {FullName} e tenho {Age} anos.");
    }
}