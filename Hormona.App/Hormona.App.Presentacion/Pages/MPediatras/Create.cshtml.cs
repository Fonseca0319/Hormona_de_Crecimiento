using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hormona.App.Dominio;
using Hormona.App.Persistencia;

namespace HospiEnCasa.App.Pages_MPediatras
{
    public class CreateModel : PageModel
    {
 private readonly IRepositorioPediatraMemoria RepositorioPediatraMemoria;
        [BindProperty]
        public Pediatra Pediatra{get; set;}
        public CreateModel(IRepositorioPediatraMemoria RepositorioPediatraMemoria) {
            this.RepositorioPediatraMemoria = RepositorioPediatraMemoria;
        }
        public void OnGet()
        {
        }
        public IActionResult OnpostSave(){
          //  if(ModelState.IsValid){
                Pediatra=RepositorioPediatraMemoria.Add(Pediatra);
                return RedirectToPage("Index");
           // }
           // else{
               // return Page();
            //}
        }
    }
}
