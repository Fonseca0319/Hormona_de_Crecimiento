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
    public class AsignarPediatraModel : PageModel
    {
        private readonly IRepositorioPediatra RepositorioPediatra;
        private readonly IRepositorioPaciente RepositorioPaciente;
        public IEnumerable<Pediatra>Pediatras{get; set;}
        [BindProperty]
        public int pediatraid{get; set;}
        [BindProperty]

        public Pediatra Pediatra{get; set;}
        [BindProperty]

        public Paciente Paciente{get; set;}
        public AsignarPediatraModel(IRepositorioPediatra RepositorioPediatra,IRepositorioPaciente RepositorioPaciente){
            this.RepositorioPediatra = RepositorioPediatra;
            this.RepositorioPaciente = RepositorioPaciente;
        }


        public IActionResult OnGet(int id)
        {
            Pediatras=RepositorioPediatra.GetAllPediatras();
            Paciente=RepositorioPaciente.GetPaciente(id);
            if(Paciente==null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }
        }
        public IActionResult OnPostToAssign(int pediatraid){
            Pediatra=RepositorioPaciente.AsignarPediatra(Paciente.id,pediatraid);
            return RedirectToPage("Index");
        }
    }
}
