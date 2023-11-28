using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppController : MonoBehaviour
{
    public FriendListController friendListController;
    
    private void Awake()
    {
        Setup();
    }

    private void Setup()
    {
        Context.Current = new Context();
        //Context.Current.friendsListService = new FriendsListServiceSubtract();
        
        friendListController.Setup();
    }

}
