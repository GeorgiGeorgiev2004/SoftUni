using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models;

public class Writer
{
    public Writer()
    {
        this.Songs= new HashSet<Song>();
    }
    [Required]
    public int Id { get; set; }
    [MaxLength(20)]
    [Required]
    public string Name { get; set; }
    public string? Pseudonym { get; set; }
    public ICollection<Song> Songs  { get; set; }
}
