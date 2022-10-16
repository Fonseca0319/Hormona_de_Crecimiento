using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
          private readonly AppContext _appContext;
          public RepositorioPaciente(AppContext appContext){
           _appContext = appContext;
            
          }

        public IEnumerable<Paciente> GetAllPacientes(){
            return _appContext.Pacientes;
        }
               

       public  Paciente AddPaciente(Paciente paciente){
        var pacienteAdicionado=_appContext.Pacientes.Add(paciente);
        _appContext.SaveChanges();
        return pacienteAdicionado.Entity;
       }
        public Paciente UpdatePaciente(Paciente paciente){
            var pacienteEncontrado=_appContext.Pacientes.FirstOrDefault(p=>p.id==paciente.id);
            if(pacienteEncontrado!=null){
                pacienteEncontrado.nombre=paciente.nombre;
                pacienteEncontrado.apellido=paciente.apellido;
                pacienteEncontrado.telefono=paciente.telefono;
                pacienteEncontrado.documento=paciente.documento;
                pacienteEncontrado.sexos=paciente.sexos;
                pacienteEncontrado.direccion=paciente.direccion;
                pacienteEncontrado.latitud=paciente.latitud;
                pacienteEncontrado.longitud=paciente.longitud;
                pacienteEncontrado.ciudad=paciente.ciudad;
                pacienteEncontrado.fechaDeNacimineto=paciente.fechaDeNacimineto;
                pacienteEncontrado.Familiar=paciente.Familiar;
                pacienteEncontrado.Pediatra=paciente.Pediatra;
                pacienteEncontrado.Endocrino=paciente.Endocrino;
                pacienteEncontrado.Historia=paciente.Historia;
               
                _appContext.SaveChanges();

            }
            return pacienteEncontrado;
        }
       public void DeletePaciente(int idpaciente){
        var pacienteEncontrado=_appContext.Pacientes.FirstOrDefault(p=>p.id==idpaciente);
        if(pacienteEncontrado==null){
            return;
        }
        _appContext.Pacientes.Remove(pacienteEncontrado);
        _appContext.SaveChanges();

       }
       public Paciente GetPaciente(int idPaciente){
        return _appContext.Pacientes.FirstOrDefault(p=>p.id==idPaciente);

       }
       public Endocrino AsignarEndocrino(int idpaciente, int idendocrino){
        var paciente=_appContext.Pacientes.FirstOrDefault(p=>p.id==idpaciente);
        if(paciente!=null){
            var endocrino=_appContext.Endocrinos.FirstOrDefault(e=>e.id==idendocrino);
            if(endocrino!=null){
                paciente.Endocrino=endocrino;
                _appContext.SaveChanges();
            }
            return endocrino;
        }
        return null;
       }
        public Pediatra AsignarPediatra(int idpaciente, int idpediatra){
        var paciente=_appContext.Pacientes.FirstOrDefault(p=>p.id==idpaciente);
        if(paciente!=null){
            var pediatra=_appContext.Pediatras.FirstOrDefault(p1=>p1.id==idpediatra);
            if(pediatra!=null){
                paciente.Pediatra=pediatra;
                _appContext.SaveChanges();
            }
            return pediatra;
        }
        return null;
      
    }
     public Historia AsignarHistoria(int idpaciente, int idhistoria){
        var paciente=_appContext.Pacientes.FirstOrDefault(p=>p.id==idpaciente);
        if(paciente!=null){
            var historia=_appContext.Historias.FirstOrDefault(h=>h.id==idhistoria);
            if(historia!=null){
                paciente.Historia=historia;
                _appContext.SaveChanges();
            }
            return historia;
        }
        return null;
      
    }
      public Familiar AsignarFamiliar(int idpaciente, int idfamiliar){
        var paciente=_appContext.Pacientes.FirstOrDefault(p=>p.id==idpaciente);
        if(paciente!=null){
            var familiar=_appContext.Familiares.FirstOrDefault(f=>f.id==idfamiliar);
            if(familiar!=null){
                paciente.Familiar=familiar;
                _appContext.SaveChanges();
            }
            return familiar;
        }
        return null;
      
   
}
public  Pediatra ConsultarPediatra(int idpaciente){
    var paciente=_appContext.Pacientes.Where(p=>p.id==idpaciente).Include(p=>p.Pediatra).FirstOrDefault();
    return paciente.Pediatra;
}
public IEnumerable<PatronDeCrecimineto>GetAllPatronDeCrecimiento(int idpaciente){
     var paciente=_appContext.Pacientes.Where(p=>p.id==idpaciente).Include(p=>p.Patrones).FirstOrDefault();
    return paciente.Patrones;
}
public IEnumerable<Paciente>PacientesPediatras(int idPediatra){
    return _appContext.Pacientes.Where(p1=>p1.Pediatra.id==idPediatra).ToList();
}
//public IEnumerable<Endocrino>PacientesEndocrinos(int idEndocrino){
    //return _appContext.Pacientes.Where(e=>e1.Endocrino.id==idEndocrino).ToList();

}
}

