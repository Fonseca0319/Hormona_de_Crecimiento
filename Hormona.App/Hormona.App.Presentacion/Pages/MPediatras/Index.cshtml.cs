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
    public class IndexModel : PageModel
    
       {
        private readonly IRepositorioPediatraMemoria RepositorioPediatraMemoria; 
        public IEnumerable<Pediatra> pediatras {get; set;}   
        public IndexModel(IRepositorioPediatraMemoria RepositorioPediatraMemoria){
            this.RepositorioPediatraMemoria= RepositorioPediatraMemoria;

        }
        public void OnGet()
        {
            pediatras=RepositorioPediatraMemoria.GetAll();
        }
    }
}
