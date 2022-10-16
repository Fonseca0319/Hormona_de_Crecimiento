using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public interface IRepositorioPacienteMemoria
    {
        IEnumerable<Paciente>GetAll();
        Paciente Add(Paciente paciente);
        Paciente Update(Paciente paciente);
        void Delete(int idPaciente);
        Paciente Get(int idPaciente);
        //Endocrino Asignar(int idpaciente, int idendocrino);
        //Pediatra AsignarPediatra(int idpaciente, int idpediatra);
       // Historia AsignarHistoria(int idpaciente, int idhistoria);
       // Familiar AsignarFamiliar(int idpaciente, int idfamiliar);
    
    }
}