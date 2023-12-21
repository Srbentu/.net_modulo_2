namespace ConsoleApp2.Models;

public class VendaRevert
{
    public int Id { get; set; }
    public string Produto { get; set; }
    public decimal Preco { get; set; }
    public DateTime DataVenda { get; set; }
    public decimal? Desconto { get; set; }
}