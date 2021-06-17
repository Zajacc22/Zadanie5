using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Zad3.Data;
using Zad3.Models;

namespace Zad3.Pages
{
    public class PobraneZBazyDanychModel : PageModel
    {
        private readonly ProductsContext _context;
        public PobraneZBazyDanychModel(ProductsContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
    }
}
