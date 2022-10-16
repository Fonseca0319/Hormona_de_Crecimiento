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
    public class DetailsModel : PageModel
    {
         private readonly IRepositorioPaciente RepositorioPaciente; 
        public Paciente Paciente {get; set;}   
        public Pediatra Pediatra {get; set;}
        public DetailsModel(IRepositorioPaciente RepositorioPaciente){
            this.RepositorioPaciente= RepositorioPaciente;

        }
        public IActionResult OnGet(int id)
        {
            Paciente=RepositorioPaciente.GetPaciente(id);
            if(Paciente==null){
                return RedirectToPage(",/NotFound");
            }
            else{
                if(RepositorioPaciente.ConsultarPediatra(id)==null){
                    Pediatra=new Pediatra{
                        nombre="Sin Asignar"
                    };
                    Paciente.Pediatra=Pediatra;
                }else{
                    Paciente.Pediatra=RepositorioPaciente.ConsultarPediatra(id);
                }
                return Page();
            }

        }
    }
}
