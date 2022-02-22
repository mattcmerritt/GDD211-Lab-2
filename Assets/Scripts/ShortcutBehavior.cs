using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortcutBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject ApplicationWindow;

    public void Open()
    {
        ApplicationWindow.SetActive(true);
    }
}
