using System;

public interface IFriendsListService
{
    int Get();
    void Set(int val);
    void Process();
    Action<int> onProcessComplete { get; set; }
}
