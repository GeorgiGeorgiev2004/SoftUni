using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Trucks.Data.Models.Enums;

namespace Trucks.DataProcessor.ImportDto
{
    [XmlType("Despatcher")]
    public class ImportDespatcherDto
    {
        [Required]
        [XmlElement("Name")]
        [MinLength(2)]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        [XmlElement("Position")]
        public string Position { get; set; }

        [XmlArray("Trucks")]
        public ImportTruckDto[] Trucks { get; set; }
    }

    [XmlType("Truck")]
    public class ImportTruckDto
    {
        [Required]
        [RegularExpression(@"[A-Z]{2}[0-9]{4}[A-Z]{2}")]
        [XmlElement("RegistrationNumber")]
        public string RegistrationNumber { get; set; } = null!;
        [Required]
        [XmlElement("VinNumber")]
        [MaxLength(17)]
        [MinLength(17)]
        public string VinNumber { get; set; } = null!;
        [Range(950,1420)]
        [XmlElement("TankCapacity")]
        public int TankCapacity { get; set; }
        [Range(5000, 29000)]
        [XmlElement("CargoCapacity")]
        public int CargoCapacity { get; set; }
        [XmlElement("CategoryType")]
        [Required]
        [Range(0,4)]
        public int CategoryType { get; set; }
        [XmlElement("MakeType")]
        [Required]
        [Range(0, 5)]
        public int MakeType { get; set; }

    }
}
