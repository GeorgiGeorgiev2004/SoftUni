using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductShop.DTOs.Export;

public class ExportSoldProductsSubfile
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("price")]
    public decimal Price { get; set; }

    [JsonProperty("buyerFirstName")]
    public string BuyerFirstName { get; set; }

    [JsonProperty("buyerLastName")]
    public string BuyerLastName { get; set;}
}
