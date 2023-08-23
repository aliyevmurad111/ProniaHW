using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Pronia.Buisness.ViewModels.SliderViewModels;

public class SliderPostVM
{
    [Required(ErrorMessage = "Fill in the boxes"), MaxLength(30), MinLength(10)]
    public string Title { get; set; } = null!;
    [Required, MaxLength(100),]
    public string Description { get; set; } = null!;
    public int Discount { get; set; }
    [Required]
    public IFormFile ImageUrl { get; set; } = null!;
}
