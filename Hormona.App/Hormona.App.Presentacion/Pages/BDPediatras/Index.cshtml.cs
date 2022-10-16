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
    public class IndexModel : PageModel
    { 
    
       
        private readonly IRepositorioPediatra RepositorioPediatra; 
        public IEnumerable<Pediatra> pediatras {get; set;}   
        public IndexModel(IRepositorioPediatra RepositorioPediatra){
            this.RepositorioPediatra= RepositorioPediatra;

        }
        public void OnGet()
        {
            pediatras=RepositorioPediatra.GetAllPediatras();
        }
    }
}

