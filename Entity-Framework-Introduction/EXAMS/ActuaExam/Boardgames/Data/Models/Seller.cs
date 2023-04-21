using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.Data.Models
{
    public class Seller
    {
        public Seller()
        {
            BoardgamesSellers = new HashSet<BoardgameSeller>();
        }
        [Key]
        public int Id { get; set; }

        [MinLength(5)]
        [MaxLength(20)]
        [Required]
        public string Name { get; set; } = null!;

        [MinLength(2)]
        [MaxLength(30)]
        [Required]
        public string Address { get; set; } = null!;
        [Required]
        public string Country { get; set; } = null!;
        [Required]
        [RegularExpression(@"\b[www.]{4}[a-zA-Z0-9-]*.{1}[com]+\b")]
        public string Website { get; set; }

        public HashSet<BoardgameSeller> BoardgamesSellers { get; set; }
    }
}
