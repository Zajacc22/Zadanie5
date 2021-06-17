using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zad3.Models
{
    public class Products
    {
            public string id { get; set; }

            public string maker { get; set; }
            [JsonPropertyName("img")]
            public string img { get; set; }
            public string url { get; set; }
            public string title { get; set; }
            public string descritprion { get; set; }

            public override string ToString() => JsonSerializer.Serialize<Products>(this);
    }
}
