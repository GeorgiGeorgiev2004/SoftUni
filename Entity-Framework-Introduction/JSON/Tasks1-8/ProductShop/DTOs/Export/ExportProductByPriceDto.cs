using Newtonsoft.Json;

namespace ProductShop.DTOs.Export;

public class ExportProductByPriceDto
{
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("price")]
    public decimal Price { get; set; }
    [JsonProperty("seller")]
    public string SellerName { get; set; }
}
