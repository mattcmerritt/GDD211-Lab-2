using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowBehavior : MonoBehaviour
{
    public void Close()
    {
        gameObject.SetActive(false);
    }
}
