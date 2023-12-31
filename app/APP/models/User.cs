
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.models;

public class UserObject : PeopleObject
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int User_ID { get; init; }
    [EmailAddress]
    public string Email { get; set; } = ".@gmail.com";
    public string? ProfilePictureURL { get; set; }
    public Dictionary<int, UserObject> Friends { get; set; } = new();
}