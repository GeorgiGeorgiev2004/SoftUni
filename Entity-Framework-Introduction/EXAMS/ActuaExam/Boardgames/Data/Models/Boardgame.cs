using Boardgames.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boardgames.Data.Models;

public class Boardgame
{
    public Boardgame()
    {
        BoardgamesSellers = new HashSet<BoardgameSeller>();
    }
    [Key]
    [Required]
    public int Id { get; set; }

    [MinLength(10)]
    [MaxLength(20)]
    [Required]
    public string Name { get; set; }

    [Range(1,10)]
    [Required]
    public double Rating { get; set; }

    [Range(2018,2023)]
    [Required]
    public int YearPublished { get; set; }
    [Required]
    [Range(0,4)]
    public CategoryType CategoryType { get; set; }
    [Required]
    public string Mechanics { get; set; } = null!;

    [ForeignKey(nameof(Creator))]
    [Required]
    public int CreatorId { get; set; }

    public Creator Creator { get; set; }

    public ICollection<BoardgameSeller> BoardgamesSellers { get; set; }
}
