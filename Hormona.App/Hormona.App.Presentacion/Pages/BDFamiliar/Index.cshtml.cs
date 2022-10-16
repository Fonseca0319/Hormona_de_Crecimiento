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
    public class IndexModel : PageModel
    {
        private readonly IRepositorioFamiliar RepositorioFamiliar; 
        public IEnumerable<Familiar> familiares {get; set;}   
        public IndexModel(IRepositorioFamiliar RepositorioFamiliar){
            this.RepositorioFamiliar= RepositorioFamiliar;

        }
        public void OnGet()
        {
            familiares=RepositorioFamiliar.GetAllFamiliares();
        }
    }
}
