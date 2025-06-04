using System.ComponentModel.DataAnnotations;

namespace RegistroCanciones_Backend.Entities;

public class Genero
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string GeneroNombre { get; set; } = null!;

    public bool IsDeleted { get; set; } = false;

    public virtual ICollection<Cancion>? Canciones { get; set; }
}
