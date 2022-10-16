namespace Hormona.App.Dominio; 

    
public class Paciente:Persona
{

    public string? direccion {get; set;}
    public float? latitud {get; set;}
    public float? longitud {get; set;}
    public string? ciudad {get; set;}
    public DateTime? fechaDeNacimineto {get; set;}
    public Familiar? Familiar {get; set;}
    public Endocrino? Endocrino {get; set;}
    public Pediatra? Pediatra {get; set;}
    public Historia? Historia {get; set;}

    
    public System.Collections.Generic.List<PatronDeCrecimineto>Patrones{get; set;}




}