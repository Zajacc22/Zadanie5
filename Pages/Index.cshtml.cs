using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Zad3.Models;
using Microsoft.Extensions.Configuration;
using Zad3.Data;
using Microsoft.Data.SqlClient;
using System.Data;
using Zad3.Services;

namespace Zad3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IConfiguration _configuration { get; }
        public IEnumerable<Products> Product { get; private set; }
        public IList<ProductsDB> ProductDB { get; set; }

        [BindProperty]

        [TempData]
        public string Message { get; set; }
        private readonly ProductsContext _context;

        public JsonFileProductService ProductService { get; }


        public IndexModel(IConfiguration configuration, ILogger<IndexModel> logger, ProductsContext context, JsonFileProductService productService)
        {
            _logger = logger;
            _configuration = configuration;
            _context = context;
            _logger = logger;
            ProductService = productService;
        }
        public void OnGet()
        {
            Product = ProductService.GetProducts();
            ProductDB = _context.ProductsDB.ToList();
        }

    }
}
