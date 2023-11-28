using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Context
{

    public static Context Current;
    
    public IFriendsListService friendsListService { get; set; }
    
    public Context()
    {
        friendsListService = new FriendsListServiceAdd();
    }

}
