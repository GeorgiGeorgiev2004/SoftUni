using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models;

public class Album
{
    public Album()
    {
        this.Songs= new HashSet<Song>();
    }
    public int Id { get; set; }
    [Required]
    [MaxLength(40)]
    public string Name { get; set; }
    [Required]
    public DateTime ReleaseDate { get; set; }
    [NotMapped]
    public decimal Price => this.Songs.Sum(s => s.Price);


    [ForeignKey(nameof(Producer))]
    public int? ProducerId { get; set; }
    public virtual Producer? Producer { get; set; }

    public ICollection<Song> Songs { get; set; }
}

