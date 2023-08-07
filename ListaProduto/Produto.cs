public class Produto
{
    public string Codigo { get; set;}
    public double PrecoAquisicao { get; set; }
    public double ValorVenda { get; set; }
    public string Descricao { get; set; }
    public double Lucro { get; set; }

    public Produto() 
    { 
    
    }
    public Produto(string codigo, double precoaquisicao, double valorvenda,string descricao, double lucro) 
    {
        this.Codigo = codigo;
        this.PrecoAquisicao = precoaquisicao;
        this.ValorVenda = valorvenda;
        this.Descricao = descricao;
        this.Lucro = lucro;
    }
}