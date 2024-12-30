public class Friend : IFriend
{
    private string name;
    private int id;

    public Friend(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
    
    public string GetName() => name;
    public int GetID() => id;
}