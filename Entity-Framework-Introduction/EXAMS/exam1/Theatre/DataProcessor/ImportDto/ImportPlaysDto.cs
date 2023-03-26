using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Theatre.Data.Models.Enums;

namespace Theatre.DataProcessor.ImportDto
{
    [XmlType("Play")]
    public class ImportPlaysDto
    {
        [XmlElement("Title")]
        [MinLength(4)]
        [MaxLength(50)]
        public string Title { get; set; } = null!;
        [XmlElement("Duration")]
        public string Duration { get; set; } = null!;
        [XmlElement("Rating")]
        [Range(0.00, 10.00)]
        public float Rating { get; set; }
        [XmlElement("Genre")]
        public Genre Genre {get;set;}

        [XmlElement("Description")]
        [MaxLength(700)]
        public string Description { get; set; } = null!;
        [XmlElement("Screenwriter")]
        [MinLength(4)]
        [MaxLength(30)]
        public string Screenwriter { get; set; }
    }
}
