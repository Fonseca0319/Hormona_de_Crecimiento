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
    public class DetailsModel : PageModel
    {
         private readonly IRepositorioEndocrino RepositorioEndocrino; 
        public Endocrino Endocrino{get; set;}   
        public DetailsModel(IRepositorioEndocrino RepositorioEndocrino){
            this.RepositorioEndocrino= RepositorioEndocrino;

        }
        public IActionResult OnGet(int id)
        {
            Endocrino=RepositorioEndocrino.GetEndocrino(id);
            if(Endocrino==null){
                return RedirectToPage(",/NotFound");
            }
            else{
                return Page();
            }
        }
    }
}
