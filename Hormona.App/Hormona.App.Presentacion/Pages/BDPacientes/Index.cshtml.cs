using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hormona.App.Dominio;
using Hormona.App.Persistencia;

namespace Hormona.App.Pages_BDPacientes
{
    public class IndexModel : PageModel
    {
 private readonly IRepositorioPaciente RepositorioPaciente; 
        public IEnumerable<Paciente> pacientes {get; set;}   
        public IndexModel(IRepositorioPaciente RepositorioPaciente){
            this.RepositorioPaciente= RepositorioPaciente;

        }
        public void OnGet()
        {
            pacientes=RepositorioPaciente.GetAllPacientes();
        }
    }
}
