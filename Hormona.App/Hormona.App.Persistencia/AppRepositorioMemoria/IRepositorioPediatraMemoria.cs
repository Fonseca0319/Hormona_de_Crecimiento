using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public interface IRepositorioPediatraMemoria
    {
        IEnumerable<Pediatra>GetAll();
        Pediatra Add(Pediatra pediatra);
        Pediatra Update(Pediatra pediatra);
        void Delete(int idPediatra);
        Pediatra Get(int idPediatra);
        //Endocrino Asignar(int idPediatra, int idendocrino);
        //Pediatra AsignarPediatra(int idPediatra, int idpediatra);
       // Historia AsignarHistoria(int idPediatra, int idhistoria);
       // Familiar AsignarFamiliar(int idPediatra, int idfamiliar);
    
    }
}