using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RegistroCanciones_Backend.Entities;

public class Cancion
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(200)]
    public string Titulo { get; set; } = null!;

    [Range(0.01, 60.0)]
    public double DuracionMinutos { get; set; }
    public bool IsDeleted { get; set; } = false;

    [Required]
    public int GeneroId { get; set; }

    public virtual Genero? Genero { get; set; }

    [Required]
    public int ArtistaId { get; set; }

    public virtual Artista? Artista { get; set; }

}
