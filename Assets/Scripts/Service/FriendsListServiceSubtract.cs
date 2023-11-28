using System;

public class FriendsListServiceSubtract : IFriendsListService
{

    public Action<int> onProcessComplete { get; set; }
    
    private int counter = 10;
    
    public int Get()
    {
        return counter;
    }
    
    public void Set(int val)
    {
        counter = val;
    }
    
    public void Process()
    {
        counter -= 1;
        onProcessComplete(counter);
    }
    
}
