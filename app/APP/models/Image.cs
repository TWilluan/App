

namespace app.models;

public class ImageObject
{
    public int Image_ID {get;init;}
    public string Image_URL{get;set;} = null!;
    public byte[] ImageData {get;set;} = null!; //image=>use byte[] to store image content
    public TagObject Tags{get;set;} = new();
    public DateTime TimeStamp{get;set;}
}