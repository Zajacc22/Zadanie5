using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace Zad3.Models
{
    public class ProductsDB
    {
            public int id { get; set; }

            public string maker { get; set; }

            public string img { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string descritprion { get; set; }

    }
}
