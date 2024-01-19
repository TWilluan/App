

using System.ComponentModel.DataAnnotations;

namespace app.models;

public class LocationObject
{
    [Required]
    public string City { get; set; } = null!;
    [Required]
    public string Country { get; set; } = null!;
}