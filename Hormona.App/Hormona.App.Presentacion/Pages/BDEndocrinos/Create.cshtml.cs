using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hormona.App.Dominio;
using Hormona.App.Persistencia;

namespace Hormona.App.Pages_BDEndocrinos
{
    public class CreateModel : PageModel
    {
private readonly IRepositorioEndocrino RepositorioEndocrino;
        [BindProperty]
        public Endocrino Endocrino{get; set;}
        public CreateModel(IRepositorioEndocrino RepositorioEndocrino) {
            this.RepositorioEndocrino = RepositorioEndocrino;
        }
        public void OnGet()
        {
        }
        public IActionResult OnpostSave(){
          //  if(ModelState.IsValid){
                Endocrino=RepositorioEndocrino.AddEndocrino(Endocrino);
                return RedirectToPage("Index");
           // }
           // else{
               // return Page();
            //}
        }
    }
}
