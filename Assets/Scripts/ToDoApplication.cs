using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ToDoApplication : MonoBehaviour
{
    private bool[] toggles = new bool[3];
    [SerializeField]
    private TMP_Text progress;
    
    public void UpdateToggle1(bool val)
    {
        toggles[0] = val;

        int total = 0;
        foreach (bool b in toggles)
        {
            if (b)
            {
                total++;
            }
        }
        float completionPercent = (float) (total) / toggles.Length * 100;
        progress.SetText("Current Progress: " + Mathf.RoundToInt(completionPercent) + "%");
    }

    // couldn't use a dynamic function to pass in the index :(
    public void UpdateToggle2(bool val)
    {
        toggles[1] = val;

        int total = 0;
        foreach (bool b in toggles)
        {
            if (b)
            {
                total++;
            }
        }
        float completionPercent = (float)(total) / toggles.Length * 100;
        progress.SetText("Current Progress: " + Mathf.RoundToInt(completionPercent) + "%");
    }

    // couldn't use a dynamic function to pass in the index :(
    public void UpdateToggle3(bool val)
    {
        toggles[2] = val;

        int total = 0;
        foreach (bool b in toggles)
        {
            if (b)
            {
                total++;
            }
        }
        float completionPercent = (float)(total) / toggles.Length * 100;
        progress.SetText("Current Progress: " + Mathf.RoundToInt(completionPercent) + "%");
    }
}
