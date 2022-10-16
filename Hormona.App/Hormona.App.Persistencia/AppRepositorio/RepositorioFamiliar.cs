using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{

    public class RepositorioFamiliar : IRepositorioFamiliar
    {
        private readonly AppContext _appContext;
        public RepositorioFamiliar(AppContext appContext){
            _appContext = appContext;
        }
        public IEnumerable<Familiar> GetAllFamiliares(){
            return _appContext.Familiares;

        }
        public Familiar AddFamiliar(Familiar familiar){
            var familiarAdicionado=_appContext.Familiares.Add(familiar);
            _appContext.SaveChanges();
            return familiarAdicionado.Entity;

        }
        public Familiar UpdateFamiliar(Familiar familiar ){
            var FamiliarEncontrado=_appContext.Familiares.FirstOrDefault(f=>f.id==familiar.id);
            if(FamiliarEncontrado!=null){
                FamiliarEncontrado.nombre=familiar.nombre;
                FamiliarEncontrado.apellido=familiar.apellido;
                FamiliarEncontrado.telefono=familiar.telefono;
                FamiliarEncontrado.documento=familiar.documento;
                FamiliarEncontrado.sexos=familiar.sexos;
                FamiliarEncontrado.parentesco=familiar.parentesco;
                FamiliarEncontrado.email=familiar.email;
                
                
                _appContext.SaveChanges();

            }

            return FamiliarEncontrado;
        }
        public void DelateFamiliar(int idfamiliar){
            var familiarEncontrado=_appContext.Familiares.FirstOrDefault(f=>f.id==idfamiliar);
            if(familiarEncontrado==null){
                return;
            }

            _appContext.Familiares.Remove(familiarEncontrado);
            _appContext.SaveChanges();

        }
        public Familiar GetFamiliar(int idfamiliar){
            return _appContext.Familiares.FirstOrDefault(f=>f.id==idfamiliar);
        }


    }

}