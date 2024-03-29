

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.models;

public class ImageObject
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Image_ID { get; init; }
    [Required]
    public string Image_URL { get; set; } = null!;
    [Required]
    public byte[] ImageData { get; set; } = null!; //image=>use byte[] to store image content
    public TagObject Tags { get; set; } = new();
    public DateTime TimeStamp { get; set; }
    [Required]
    public int User_ID { get; set; }
    public UserObject User { get; set; } = null!; //has one user
}