using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public interface IRepositorioHistoria
    {
        IEnumerable<Historia>GetAllHistoria();
        Historia AddHistoria(Historia historia);
        Historia UpdateHistoria(Historia historia);
        void DeleteHistoria(int idHistoria);
        Historia GetHistoria(int idHistoria);
        
    }
}