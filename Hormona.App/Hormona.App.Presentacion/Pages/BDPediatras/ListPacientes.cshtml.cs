using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hormona.App.Dominio;
using Hormona.App.Persistencia;

namespace Hormona.App.Pages_BDPediatras
{
    public class ListPacientesModel : PageModel
    {
        private readonly IRepositorioPaciente RepositorioPaciente;
       public IEnumerable<Paciente> Pacientes{get; set;}
       [BindProperty(SupportsGet=true)]
       public int GetFilters{get; set;}
       public ListPacientesModel(IRepositorioPaciente RepositorioPaciente){
        this.RepositorioPaciente = RepositorioPaciente;

       }
        public void OnGet(int GetFilters)
        {
            Pacientes=RepositorioPaciente.PacientesPediatras(GetFilters);
        }
    }
}
