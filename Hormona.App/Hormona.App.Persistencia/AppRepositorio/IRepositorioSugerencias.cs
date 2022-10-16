using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public interface IRepositorioSugerencias
    {
        IEnumerable<SugerenciasDeCiudado>GetAllSugerencias();
        SugerenciasDeCiudado AddSugerencias(SugerenciasDeCiudado sugerenciasDeCiudado);
       
        SugerenciasDeCiudado GetSugerencias(int idsugerenciasDeCuidado);

        
    }
}