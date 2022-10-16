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
    public class AsignarEndocrinosModel : PageModel
    {
 private readonly IRepositorioEndocrino RepositorioEndocrino;
        private readonly IRepositorioPaciente RepositorioPaciente;
        public IEnumerable<Endocrino>Endocrinos{get; set;}
        [BindProperty]
        public int Endocrinoid{get; set;}
        [BindProperty]

        public Endocrino Endocrino{get; set;}
        [BindProperty]

        public Paciente Paciente{get; set;}
        public AsignarEndocrinosModel(IRepositorioEndocrino RepositorioEndocrino,IRepositorioPaciente RepositorioPaciente){
            this.RepositorioEndocrino = RepositorioEndocrino;
            this.RepositorioPaciente = RepositorioPaciente;
        }


        public IActionResult OnGet(int id)
        {
            Endocrinos=RepositorioEndocrino.GetAllEndocrinos();
            Paciente=RepositorioPaciente.GetPaciente(id);
            if(Paciente==null){
                return RedirectToPage("./NotFound");
            }
            else{
                return Page();
            }
        }
        public IActionResult OnPostToAssign(int Endocrinoid){
            Endocrino=RepositorioPaciente.AsignarEndocrino(Paciente.id,Endocrinoid);
            return RedirectToPage("Index");
    }
}
}
