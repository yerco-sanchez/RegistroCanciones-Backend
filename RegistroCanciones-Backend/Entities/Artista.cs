using System.ComponentModel.DataAnnotations;

namespace RegistroCanciones_Backend.Entities;

public class Artista
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(150)]
    public string Nombre { get; set; } = null!;

    [MaxLength(100)]
    public string Nacionalidad { get; set; } = "";

    public DateTime? FechaNacimiento { get; set; }

    public bool IsDeleted { get; set; } = false;

    public virtual ICollection<Cancion>? Canciones { get; set; }
}
