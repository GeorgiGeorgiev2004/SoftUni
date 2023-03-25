using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace ProductShop.DTOs.Import;

public class ImportCategoryProductDto
{
    [JsonProperty("CategoryId")]
    public int CategoryId { get; set; }

    [JsonProperty("ProductId")]
    public int ProductId { get; set; }
}
