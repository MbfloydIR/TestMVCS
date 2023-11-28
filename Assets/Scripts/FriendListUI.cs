using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FriendListUI : MonoBehaviour
{
    public Button testButton;
    public TextMeshProUGUI testText;

    public Action onTest;
    
    public void Setup()
    {
        testButton.onClick.AddListener(OnTestButtonClick);
    }

    private void OnTestButtonClick()
    {
        Test();
    }

    private void Test()
    {
        onTest?.Invoke();
    }

    public void SetTestText(string text)
    {
        testText.text = text;
    }
    
}
