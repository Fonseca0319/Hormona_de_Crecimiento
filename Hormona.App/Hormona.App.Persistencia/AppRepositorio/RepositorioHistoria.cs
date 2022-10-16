using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {
          private readonly AppContext _appContext;
          public RepositorioHistoria(AppContext appContext){
           _appContext = appContext;
            
          }

        public IEnumerable<Historia> GetAllHistoria(){
            return _appContext.Historias;
        }
               

       public  Historia AddHistoria(Historia historia){
        var historiaAdicionado=_appContext.Historias.Add(historia);
        _appContext.SaveChanges();
        return historiaAdicionado.Entity;
       }
        public Historia UpdateHistoria(Historia historia){
            var historiaEncontrado=_appContext.Historias.FirstOrDefault(h=>h.id==historia.id);
            if(historiaEncontrado!=null){
               
                historiaEncontrado.diagnostico=historia.diagnostico;
                
                
               
                _appContext.SaveChanges();

            }
            return historiaEncontrado;
        }
       public void DeleteHistoria(int idHistoria){
         var historiaEncontrado=_appContext.Historias.FirstOrDefault(h=>h.id==idHistoria);
        if(historiaEncontrado==null){
            return;
        }
        _appContext.Historias.Remove(historiaEncontrado);
        _appContext.SaveChanges();

       }
       public Historia GetHistoria(int idHistoria){
        return _appContext.Historias.FirstOrDefault(h=>h.id==idHistoria);

        }
     
    }
}