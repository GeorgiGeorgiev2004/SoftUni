using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.DataProcessor.ImportDto
{
    public class ImportJsonSeller
    {
        public ImportJsonSeller()
        {
            Boardgames = new List<int>();
        }
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Address { get; set; }
        [Required]
        public string Country { get; set; }
        [RegularExpression(@"\b[www.]{4}[a-zA-Z0-9-]*.{1}[com]+\b")]
        [Required]
        public string Website { get; set; }
        public ICollection<int> Boardgames { get; set; }
    }
}
