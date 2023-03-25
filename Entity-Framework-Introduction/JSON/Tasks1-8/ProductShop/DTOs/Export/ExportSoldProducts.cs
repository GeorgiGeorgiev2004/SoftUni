using Newtonsoft.Json;

namespace ProductShop.DTOs.Export;

public class ExportSoldProducts
{
   
    [JsonProperty("firstName")]
    public string FirstName { get; set; }

    [JsonProperty("lastName")]
    public string LastName { get; set; }

    [JsonProperty("soldProducts")]
    public List<ExportSoldProductsSubfile> SoldProducts { get; set; }
}
