using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hormona.App.Dominio;
using Hormona.App.Persistencia;

namespace Hormona.App.Pages_BDFamiliar
{
    public class CreateModel : PageModel
    {
private readonly IRepositorioFamiliar RepositorioFamiliar;
        [BindProperty]
        public Familiar Familiar{get; set;}
        public CreateModel(IRepositorioFamiliar RepositorioFamiliar) {
            this.RepositorioFamiliar = RepositorioFamiliar;
        }
        public void OnGet()
        {
        }
        public IActionResult OnpostSave(){
          //  if(ModelState.IsValid){
                Familiar=RepositorioFamiliar.AddFamiliar(Familiar);
                return RedirectToPage("Index");
           // }
           // else{
               // return Page();
            //}
        }
    }
}
