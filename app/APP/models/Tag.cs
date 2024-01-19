

using System.ComponentModel.DataAnnotations;

namespace app.models;

public class TagObject
{
    [Required]
    public LocationObject Location { get; set; } = default!;
    public Dictionary<int, UserObject> SharedWith { get; set; } = new();
}