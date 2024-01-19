

using app.models;
namespace app.DTOs;

public class ImageDTO_create
{
    public string Image_URL { get; set; } = null!;
    public byte[] ImageData { get; set; } = null!; //image=>use byte[] to store image content
    public TagObject Tags { get; set; } = new();
    public DateTime TimeStamp { get; set; }
    public int User_ID { get; set; }
    public UserObject User { get; set; } = null!; //has one user
}