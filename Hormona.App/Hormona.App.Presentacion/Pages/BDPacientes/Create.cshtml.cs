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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPaciente RepositorioPaciente;
        [BindProperty]
        public Paciente Paciente{get; set;}
        public CreateModel(IRepositorioPaciente RepositorioPaciente){
            this.RepositorioPaciente =RepositorioPaciente;
        }
        public void OnGet()
        {
        }
         public IActionResult OnPostSave(){
            Paciente=RepositorioPaciente.AddPaciente(Paciente);
            return RedirectToPage("Index");
                
            }
}
}
