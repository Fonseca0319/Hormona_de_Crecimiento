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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPacienteMemoria RepositorioPacienteMemoria;
        [BindProperty]
        public Paciente Paciente{get; set;}
        public CreateModel(IRepositorioPacienteMemoria RepositorioPacienteMemoria) {
            this.RepositorioPacienteMemoria = RepositorioPacienteMemoria;
        }
        public void OnGet()
        {
        }
        public IActionResult OnpostSave(){
          //  if(ModelState.IsValid){
                Paciente=RepositorioPacienteMemoria.Add(Paciente);
                return RedirectToPage("Index");
           // }
           // else{
               // return Page();
            //}
        }
    }
}
