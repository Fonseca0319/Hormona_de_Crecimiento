using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public class RepositorioEndocrino : IRepositorioEndocrino
    {
          private readonly AppContext _appContext;
          public RepositorioEndocrino(AppContext appContext){
           _appContext = appContext;
            
          }

        public IEnumerable<Endocrino> GetAllEndocrinos(){
            return _appContext.Endocrinos;
        }
               

       public  Endocrino AddEndocrino(Endocrino endocrino){
        var EndocrinoAdicionado=_appContext.Endocrinos.Add(endocrino);
        _appContext.SaveChanges();
        return EndocrinoAdicionado.Entity;
       }
        public Endocrino UpdateEndocrino(Endocrino endocrino){
            var endocrinoEncontrado=_appContext.Endocrinos.FirstOrDefault(e=>e.id==endocrino.id);
            if(endocrinoEncontrado!=null){
                endocrinoEncontrado.nombre=endocrino.nombre;
                endocrinoEncontrado.apellido=endocrino.apellido;
                endocrinoEncontrado.telefono=endocrino.telefono;
                endocrinoEncontrado.documento=endocrino.documento;
                endocrinoEncontrado.sexos=endocrino.sexos;
                endocrinoEncontrado.codigo=endocrino.codigo;
                endocrinoEncontrado.registro=endocrino.registro;
                
               
                _appContext.SaveChanges();

            }
            return endocrinoEncontrado;
        }
       public void DeleteEndocrino(int idendocrino){
        var endocrinoEncontrado=_appContext.Endocrinos.FirstOrDefault(e=>e.id==idendocrino);
        if(endocrinoEncontrado==null){
            return;
        }
        _appContext.Endocrinos.Remove(endocrinoEncontrado);
        _appContext.SaveChanges();

       }
       public Endocrino GetEndocrino(int idEndocrino){
        return _appContext.Endocrinos.FirstOrDefault(e=>e.id==idEndocrino);

       }
    }
}
