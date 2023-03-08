using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MusicHub.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicHub.Data.Models;

public class Song
{
    public Song()
    {
        this.SongPerformers = new HashSet<SongPerformer>();
    }
    [Key]
    public int Id { get; set; }

    [MaxLength(20)]
    [Required]
    public string Name { get; set; }

    [Required]
    public TimeSpan Duration { get; set; }
    [Required]
    public DateTime CreatedOn { get; set; }


    [Required]
    public Genre Genre { get; set; }

    [ForeignKey(nameof(Album))]
    public int? AlbumId { get; set; }
    public Album Album { get; set; }
    [Required]
    [ForeignKey(nameof(Writer))]
    public int WriterId { get; set; }
    public Writer Writer { get; set; }

    [Required]
    public decimal Price { get; set; }

    public ICollection<SongPerformer> SongPerformers  { get; set; }
}
