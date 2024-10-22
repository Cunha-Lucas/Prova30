namespace Lucas.Models;

public class Funcionario
{
    public Funcionario()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string? Id { get; set; }
    public string? cpf { get; set; }
    public string? nome { get; set; }
}