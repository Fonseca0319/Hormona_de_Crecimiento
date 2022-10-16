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
    public class EditModel : PageModel
    {
        private readonly IRepositorioPaciente RepositorioPaciente;
        [BindProperty]
        public Paciente Paciente {get; set;}
        public  EditModel(IRepositorioPaciente RepositorioPaciente){
            this.RepositorioPaciente = RepositorioPaciente;
        }
        public IActionResult OnGet(int id)
        {
                Paciente=RepositorioPaciente.GetPaciente(id);
                if(Paciente==null){
                    return RedirectToPage("./NotFound");
                }
                else{
                    return Page();
                }
        }
        public IActionResult OnPostEdit(){
            Paciente=RepositorioPaciente.UpdatePaciente(Paciente);
           return RedirectToPage("Index");
        }
    }
}
