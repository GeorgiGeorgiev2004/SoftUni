using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trucks.DataProcessor.ImportDto;

public class ImportClientDto
{
    public ImportClientDto()
    {
        Trucks = new HashSet<int>();
    }
    [JsonProperty("Name")]
    [MinLength(3)]
    [MaxLength(40)]
    public string Name { get; set; }
    [MinLength(2)]
    [MaxLength(40)]
    [JsonProperty("Nationality")]
    public string Nationality { get; set; }
    [JsonProperty("Type")]
    public string Type { get; set; }
    [JsonProperty("Trucks")]
    public ICollection<int> Trucks { get; set; }
}
