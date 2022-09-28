using System.ComponentModel.DataAnnotations;

namespace Clase6.Evaluacion.Entidades;

public class AlquilerAuto
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Nombre de cliente es requerido")]
    public string NombreCliente { get; set; }

    [StringLength(20, ErrorMessage = "Modelo no puede exceder los 20 caracteres de longitud")]
    public string? Modelo { get; set; }

    [Required(ErrorMessage = "Cantidad de dias es requerida")]
    [Range(1, 365, ErrorMessage = "Cantidad de dias debe ser mayor a 0 y menor a 366 dias")]
    public int CantidadDias { get; set; }
    public int PrecioAlquiler { get; set; }

}