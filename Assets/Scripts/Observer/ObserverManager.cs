using UnityEngine;
using System;

public class ObserverManager : MonoBehaviour
{
    public static event Action OnClickButton;


    public void ClickedButton()
    {
        OnClickButton?.Invoke();
    }
}
