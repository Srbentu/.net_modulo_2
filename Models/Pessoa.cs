namespace ConsoleApp2.Models;

public class Pessoa
{
    public Pessoa(){}//construtor vazio é necessário para que o construtor com parâmetros funcione 
    public Pessoa(string name, string lastname)
    {
        Name = name;
        LastName = lastname;
    }
    public void Deconstruct(out string name, out string lastname)
    {
        name = Name;
        lastname = LastName;
    }
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