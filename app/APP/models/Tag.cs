

namespace app.models;

public class TagObject
{
    public LocationObject Location { get; set; } = default!;
    public Dictionary<int, UserObject> SharedWith { get; set; } = new();
}