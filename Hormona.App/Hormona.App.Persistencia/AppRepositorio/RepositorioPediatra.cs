using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public class RepositorioPediatra : IRepositorioPediatra
    {
          private readonly AppContext _appContext;
          public RepositorioPediatra(AppContext appContext){
           _appContext = appContext;
            
          }

        public IEnumerable<Pediatra> GetAllPediatras(){
            return _appContext.Pediatras;
        }
               

       public  Pediatra AddPediatra(Pediatra pediatra){
        var PediatraAdicionado=_appContext.Pediatras.Add(pediatra);
        _appContext.SaveChanges();
        return PediatraAdicionado.Entity;
       }
        public Pediatra UpdatePediatra(Pediatra pediatra){
            var pediatraEncontrado=_appContext.Pediatras.FirstOrDefault(p1=>p1.id==pediatra.id);
            if(pediatraEncontrado!=null){
                pediatraEncontrado.nombre=pediatra.nombre;
                pediatraEncontrado.apellido=pediatra.apellido;
                pediatraEncontrado.telefono=pediatra.telefono;
                pediatraEncontrado.documento=pediatra.documento;
                pediatraEncontrado.sexos=pediatra.sexos;
                pediatraEncontrado.codigo=pediatra.codigo;
                pediatraEncontrado.registro=pediatra.registro;
                
               
                _appContext.SaveChanges();

            }
            return pediatraEncontrado;
        }
       public void DeletePediatra(int idpediatra){
        var pediatraEncontrado=_appContext.Pediatras.FirstOrDefault(p1=>p1.id==idpediatra);
        if(pediatraEncontrado==null){
            return;
        }
        _appContext.Pediatras.Remove(pediatraEncontrado);
        _appContext.SaveChanges();

       }
       public Pediatra GetPediatra(int idPediatra){
        return _appContext.Pediatras.FirstOrDefault(p1=>p1.id==idPediatra);

       }
    }
}
