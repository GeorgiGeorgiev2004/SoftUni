using Boardgames.DataProcessor.ImportDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ExportDto
{
    [XmlType("Creator")]
    public class ExportXmlDto
    {
        [XmlAttribute("BoardgamesCount")]
        public int Count { get; set; }
        [XmlElement("CreatorName")]
        public string CreatorName { get; set; }
        [XmlArray()]
        public ExportBoardgamesDto[] Boardgames { get; set; }
    }
}
