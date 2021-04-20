using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickControl : MonoBehaviour
{
    public Text hintCounterText;
    private int hintCount;

    // https://forum.unity.com/threads/replace-void-onmousedown-for-android.891394/


    public void onItemTouched() {
        Debug.Log("You found me!");
        //Animate it disappearing into the scene
        Destroy(gameObject);
        int.TryParse(hintCounterText.text, out hintCount);
        hintCount--;
        if (hintCount >= 0)
        {
            hintCounterText.text = hintCount.ToString();
        }
        else
        {
            //New item to find
        }
    }

    void OnMouseDown()
    {
        //onItemTouched();
    }
}
