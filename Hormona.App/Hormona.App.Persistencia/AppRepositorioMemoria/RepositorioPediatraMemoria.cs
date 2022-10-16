using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using Hormona.App.Dominio;
namespace Hormona.App.Persistencia
{
    public class RepositorioPediatraMemoria : IRepositorioPediatraMemoria
    {
        List<Pediatra> pediatras;
        public RepositorioPediatraMemoria()
        {
            pediatras = new List<Pediatra>(){
                 new Pediatra{
                id = 1,
                nombre = "Roberto",
                apellido = "Carlos",
                telefono = "313422",
                sexos = Sexo.Masculino,
                documento = "1016454392",
                codigo="14423",
                registro="35324"
                

                 },
                     new Pediatra{
                id = 2,
                nombre = "Grabiel",
                apellido = "Garcia",
                telefono = "31014222233",
                sexos = Sexo.Masculino,
                documento = "10234242",
                codigo="123123",
                registro="34424"

             

                 }

            };
        }
        public IEnumerable<Pediatra> GetAll(){
            return pediatras;
        }
   
        
        public Pediatra Add(Pediatra pediatra)
        {
            pediatra.id=pediatras.Max(p1=>p1.id)+1;
            pediatras.Add(pediatra);
            return pediatra;
        }
        public Pediatra Update(Pediatra pediatra)
        {
            throw new NotFiniteNumberException();
        }
        public void Delete(int idPediatra)
        {
            throw new NotFiniteNumberException();
        }
        public Pediatra Get(int idPediatra)
        {
           return pediatras.SingleOrDefault(p1 => p1.id == idPediatra);
        }
        //Endocrino Asignar(int idpaciente, int idendocrino);
        //Pediatra AsignarPediatra(int idpaciente, int idpediatra);
        // Historia AsignarHistoria(int idpaciente, int idhistoria);
        // Familiar AsignarFamiliar(int idpaciente, int idfamiliar);

    }
}