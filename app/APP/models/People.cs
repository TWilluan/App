

using System.ComponentModel.DataAnnotations;

namespace app.models;

public class PeopleObject
{
    [Required]
    public string first_name { get; set; } = string.Empty;
    [Required]
    public string last_name { get; set; } = string.Empty;
    public string? middle_name { get; set; }

    public string getFullName()
    {
        if (middle_name == "")
            return first_name + " " + last_name;
        return first_name + " " + middle_name + " " + last_name;
    }
}