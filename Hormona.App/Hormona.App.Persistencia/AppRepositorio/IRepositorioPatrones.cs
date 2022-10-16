using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public interface IRepositorioPatrones
    {
        IEnumerable<PatronDeCrecimineto>GetAllPatrones();
        PatronDeCrecimineto AddPatrones(PatronDeCrecimineto patrones);
       
        PatronDeCrecimineto GetPatrones(int idpatrones);

        
    }
}