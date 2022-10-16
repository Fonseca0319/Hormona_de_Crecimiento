using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public interface IRepositorioPaciente 
    {
        IEnumerable<Paciente>GetAllPacientes();
        Paciente AddPaciente(Paciente paciente);
        Paciente UpdatePaciente(Paciente paciente);
        void DeletePaciente(int idPaciente);
        Paciente GetPaciente(int idPaciente);
        Endocrino AsignarEndocrino(int idpaciente, int idendocrino);
        Pediatra AsignarPediatra(int idpaciente, int idpediatra);
        Historia AsignarHistoria(int idpaciente, int idhistoria);
        Familiar AsignarFamiliar(int idpaciente, int idfamiliar);
        Pediatra ConsultarPediatra(int idpaciente);
         IEnumerable<PatronDeCrecimineto>GetAllPatronDeCrecimiento(int idpaciente); 
         IEnumerable<Paciente>PacientesPediatras(int idPediatra);
         //
    
    }
}
