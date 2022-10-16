using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{

    public interface IRepositorioFamiliar
    {

        IEnumerable<Familiar> GetAllFamiliares();
        Familiar AddFamiliar(Familiar familiar);
        Familiar UpdateFamiliar(Familiar familiar );
        void DelateFamiliar(int idfamiliar);
        Familiar GetFamiliar(int idfamiliar);


    }

}