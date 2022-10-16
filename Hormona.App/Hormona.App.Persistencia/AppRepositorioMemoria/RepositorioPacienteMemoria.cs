using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public class RepositorioPacienteMemoria : IRepositorioPacienteMemoria
    {
        List<Paciente> pacientes;
        public RepositorioPacienteMemoria()
        {
            pacientes = new List<Paciente>(){
                 new Paciente{
                id = 1,
                nombre = "Ivanna",
                apellido = "Fonseca Gomez",
                telefono = "3101032",
                sexos = Sexo.Femenino,
                documento = "1011010192",
                direccion = "cr 44 #12a",
                latitud = 4.324234F,
                longitud = -2.324223F,
                ciudad = "Armenia",
                fechaDeNacimineto = new DateTime(2021, 01, 19),

                 },
                     new Paciente{
                id = 2,
                nombre = "Migel",
                apellido = "Trujillo Cubillos",
                telefono = "310123133",
                sexos = Sexo.Masculino,
                documento = "108755322",
                direccion = "cr 23 #12a",
                latitud = 4.322F,
                longitud = -2.342323F,
                ciudad = "Armenia",
                fechaDeNacimineto = new DateTime(2005, 01, 19),

                 }

            };
        }
        public IEnumerable<Paciente> GetAll(){
            return pacientes;
        }
   
        
        public Paciente Add(Paciente paciente)
        {
            paciente.id=pacientes.Max(p=>p.id)+1;
            pacientes.Add(paciente);
            return paciente;
        }
        public Paciente Update(Paciente paciente)
        {
            throw new NotFiniteNumberException();
        }
        public void Delete(int idPaciente)
        {
            throw new NotFiniteNumberException();
        }
        public Paciente Get(int idPaciente)
        {
           return pacientes.SingleOrDefault(p => p.id == idPaciente);
        }
        //Endocrino Asignar(int idpaciente, int idendocrino);
        //Pediatra AsignarPediatra(int idpaciente, int idpediatra);
        // Historia AsignarHistoria(int idpaciente, int idhistoria);
        // Familiar AsignarFamiliar(int idpaciente, int idfamiliar);

    }
}