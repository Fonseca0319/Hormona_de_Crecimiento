using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public interface IRepositorioEndocrino
    {
        IEnumerable<Endocrino>GetAllEndocrinos();
        Endocrino AddEndocrino(Endocrino endocrino);
        Endocrino UpdateEndocrino(Endocrino endocrino);
        void DeleteEndocrino(int idEndocrino);
        Endocrino GetEndocrino(int idEndocrino);
    }
}
