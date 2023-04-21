using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ImportDto
{
    [XmlType("Boardgame")]
    public class ImportBoardgamesDto
    {
        [MinLength(10)]
        [MaxLength(20)]
        [Required]
        [XmlElement("Name")]
        public string Name { get; set; } = null!;
        [Range(1, 10)]
        [Required]
        [XmlElement("Rating")]
        public double Rating { get; set; }
        [Range(2018, 2023)]
        [Required]
        [XmlElement("YearPublished")]
        public int YearPublished { get; set; }
        [Required]
        [Range(0, 4)]
        [XmlElement("CategoryType")]
        public int CategoryType { get; set; }
        [Required]
        [XmlElement("Mechanics")]
        public string Mechanics { get; set; }=null!;
    }
}
