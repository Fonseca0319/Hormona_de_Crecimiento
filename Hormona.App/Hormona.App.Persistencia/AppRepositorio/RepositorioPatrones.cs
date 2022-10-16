using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public class RepositorioPatrones:IRepositorioPatrones
    {
          private readonly AppContext _appContext;
          public RepositorioPatrones(AppContext appContext){
           _appContext = appContext;
            
          }

        public IEnumerable<PatronDeCrecimineto> GetAllPatrones(){
            return _appContext.Patrones;
        }
               

       public  PatronDeCrecimineto AddPatrones(PatronDeCrecimineto patrones){
        var patronesAdicionado=_appContext.Patrones.Add(patrones);
        _appContext.SaveChanges();
        return patronesAdicionado.Entity;
       }
    
      
       public PatronDeCrecimineto GetPatrones(int idpatrones){
        return _appContext.Patrones.FirstOrDefault(p2=>p2.id==idpatrones);

     
      
    }
    }
}