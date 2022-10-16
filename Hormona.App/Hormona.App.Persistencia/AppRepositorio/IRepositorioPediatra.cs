using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public interface IRepositorioPediatra
    {
        IEnumerable<Pediatra>GetAllPediatras();
        Pediatra AddPediatra(Pediatra pediatra);
        Pediatra UpdatePediatra(Pediatra pediatra);
        void DeletePediatra(int idPediatra);
        Pediatra GetPediatra(int idPediatra);
    }
}
