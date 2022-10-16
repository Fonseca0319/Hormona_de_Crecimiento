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
    public class AddPatronesModel : PageModel
    {
        private readonly IRepositorioPaciente RepositorioPaciente;
        [BindProperty]
        public PatronDeCrecimineto PatronDeCrecimineto{get; set;} 
       [BindProperty]
        public Paciente Paciente{get; set;}
       public AddPatronesModel(IRepositorioPaciente RepositorioPaciente){
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
        public IActionResult OnPostSave(){
            if(Paciente.id>0){
                var paciente=RepositorioPaciente.GetPaciente(Paciente.id);
                if(Paciente!=null){
                    if(paciente.Patrones!=null){
                        paciente.Patrones.Add(PatronDeCrecimineto);
                    }
                    else{
                        paciente.Patrones=new List<PatronDeCrecimineto>{
                           new PatronDeCrecimineto{
                                fechaHora=PatronDeCrecimineto.fechaHora,
                                valor=PatronDeCrecimineto.valor,
                               patronesDeCrecimiento=PatronDeCrecimineto.patronesDeCrecimiento

                            }
                        };
                    }
                    RepositorioPaciente.UpdatePaciente(paciente);
               }
                return RedirectToPage("Index");
            }
            else{
                return Page();
            }
       }
    }
}

