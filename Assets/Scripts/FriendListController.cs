using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendListController : MonoBehaviour
{

    public FriendListUI friendListUI;


    public void Setup()
    {
        friendListUI.Setup();
        friendListUI.onTest += FriendsListTest;
        UpdateTextText( Context.Current.friendsListService.Get() );
    }

    private void FriendsListTest()
    {
        FriendsListServiceProcess();
    }

    private void FriendsListServiceProcess()
    {
        Context.Current.friendsListService.onProcessComplete += FriendsListServiceProcessComplete;
        Context.Current.friendsListService.Process();
    }
    
    private void FriendsListServiceProcessComplete(int val )
    {
        Context.Current.friendsListService.onProcessComplete -= FriendsListServiceProcessComplete;
        UpdateTextText(val);
    }

    private void UpdateTextText(int val )
    {
        friendListUI.SetTestText(val.ToString());
    }
    
    //Context.Current.friendsListService
}
