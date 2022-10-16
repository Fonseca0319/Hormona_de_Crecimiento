namespace Hormona.App.Dominio;

public class Persona
{
    public int id { get; set; }
  
    public string? nombre { get; set; }
    public string? apellido { get; set; }
    public string? telefono { get; set; }
    public string? documento { get; set; }
    public Sexo? sexos { get; set; }
}
