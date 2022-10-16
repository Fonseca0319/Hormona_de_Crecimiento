using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hormona.App.Dominio;
using Hormona.App.Persistencia;


namespace Hormona.App.Pages_BDPediatras
{
    public class CreateModel : PageModel
    {
private readonly IRepositorioPediatra RepositorioPediatra;
        [BindProperty]
        public Pediatra Pediatra{get; set;}
        public CreateModel(IRepositorioPediatra RepositorioPediatra) {
            this.RepositorioPediatra = RepositorioPediatra;
        }
        public void OnGet()
        {
        }
        public IActionResult OnpostSave(){
          //  if(ModelState.IsValid){
                Pediatra=RepositorioPediatra.AddPediatra(Pediatra);
                return RedirectToPage("Index");
           // }
           // else{
               // return Page();
            //}
        }
    }
}
