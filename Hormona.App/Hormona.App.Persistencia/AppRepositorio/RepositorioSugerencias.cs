using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public class RepositorioSugerencias:IRepositorioSugerencias
    {
          private readonly AppContext _appContext;
          public RepositorioSugerencias(AppContext appContext){
           _appContext = appContext;
            
          }

        public IEnumerable<SugerenciasDeCiudado> GetAllSugerencias(){
            return _appContext.sugerencias;
        }
               

       public  SugerenciasDeCiudado AddSugerencias(SugerenciasDeCiudado sugerenciasDeCiudado){
        var sugerenciasAdicionado=_appContext.sugerencias.Add(sugerenciasDeCiudado);
        _appContext.SaveChanges();
        return sugerenciasAdicionado.Entity;
       }
    
      
       public SugerenciasDeCiudado GetSugerencias(int idsugerenciasDeCuidado){
        return _appContext.sugerencias.FirstOrDefault(s=>s.id==idsugerenciasDeCuidado);

     
      
    }
    }
}