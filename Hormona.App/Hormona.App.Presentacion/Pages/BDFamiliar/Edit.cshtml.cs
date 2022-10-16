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
    public class EditModel : PageModel
    {
  private readonly IRepositorioFamiliar RepositorioFamiliar;
        [BindProperty]
        public Familiar Familiar {get; set;}
        public  EditModel(IRepositorioFamiliar RepositorioFamiliar){
            this.RepositorioFamiliar = RepositorioFamiliar;
        }
        public IActionResult OnGet(int id)
        {
                Familiar=RepositorioFamiliar.GetFamiliar(id);
                if(Familiar==null){
                    return RedirectToPage("./NotFound");
                }
                else{
                    return Page();
                }
        }
        public IActionResult OnPostEdit(){
            Familiar=RepositorioFamiliar.UpdateFamiliar(Familiar);
           return RedirectToPage("Index");
    }
}
}
