using System.ComponentModel.DataAnnotations;

namespace Imc.Models;

public class ImcModel
{
    [Required(ErrorMessage = "Informe a altura")]
    [Range(1, 3, ErrorMessage = "altura invalida")]
    public double? Heigth { get; set; } //altura
    
    [Required(ErrorMessage = "Informe o peso")]
    [Range(15, 180, ErrorMessage = "peso invalido")]
    public double? Weigth { get; set; } //peso

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public double Imc => (Weigth ?? 1) / ((Heigth ?? 1) * (Heigth ?? 1));

}