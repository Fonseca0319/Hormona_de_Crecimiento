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
    public class IndexModel : PageModel
    {
 
        private readonly IRepositorioEndocrino RepositorioEndocrino; 
        public IEnumerable<Endocrino> Endocrinos {get; set;}   
        public IndexModel(IRepositorioEndocrino RepositorioEndocrino){
            this.RepositorioEndocrino= RepositorioEndocrino;

        }
        public void OnGet()
        {
            Endocrinos=RepositorioEndocrino.GetAllEndocrinos();
        }
    }
}
