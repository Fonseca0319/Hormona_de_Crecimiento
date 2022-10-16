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
    public class AsignarFamiliarModel : PageModel
    {
 private readonly IRepositorioFamiliar RepositorioFamiliar;
        private readonly IRepositorioPaciente RepositorioPaciente;
        public IEnumerable<Familiar>Familiares{get; set;}
        [BindProperty]
        public int familiarid{get; set;}
        [BindProperty]

        public Familiar Familiar{get; set;}
        [BindProperty]

        public Paciente Paciente{get; set;}
        public AsignarFamiliarModel( IRepositorioFamiliar RepositorioFamiliar,IRepositorioPaciente RepositorioPaciente){
            this.RepositorioFamiliar = RepositorioFamiliar;
            this.RepositorioPaciente = RepositorioPaciente;
        }


        public IActionResult OnGet(int id)
        {
            Familiares=RepositorioFamiliar.GetAllFamiliares();
            Paciente=RepositorioPaciente.GetPaciente(id);
            if(Paciente==null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }
        }
        public IActionResult OnPostToAssign(int familiarid){
            Familiar=RepositorioPaciente. AsignarFamiliar(Paciente.id,familiarid);
            return RedirectToPage("Index");
        }
    }
}
