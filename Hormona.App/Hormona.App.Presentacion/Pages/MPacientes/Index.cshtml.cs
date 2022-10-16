using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hormona.App.Dominio;
using Hormona.App.Persistencia;

namespace Hormona.App.Pages_MPacientes
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPacienteMemoria RepositorioPacienteMemoria; 
        public IEnumerable<Paciente> pacientes {get; set;}   
        public IndexModel(IRepositorioPacienteMemoria RepositorioPacienteMemoria){
            this.RepositorioPacienteMemoria= RepositorioPacienteMemoria;

        }
        public void OnGet()
        {
            pacientes=RepositorioPacienteMemoria.GetAll();
        }
    }
}
