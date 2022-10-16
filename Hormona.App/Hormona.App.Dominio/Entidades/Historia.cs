namespace Hormona.App.Dominio; 

    
public class Historia
{
    public int id {get; set;}
    public string? diagnostico {get; set;}
    public System.Collections.Generic.List<SugerenciasDeCiudado>sugerencias{get; set;}
    


}