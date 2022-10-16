namespace Hormona.App.Dominio; 

    public class PatronDeCrecimineto
    {
     
        public int id { get; set;}
        public DateTime? fechaHora {get; set; }
        public float? valor {get; set;}

        public PatronesDeCrecimiento? patronesDeCrecimiento {get; set;}
    }