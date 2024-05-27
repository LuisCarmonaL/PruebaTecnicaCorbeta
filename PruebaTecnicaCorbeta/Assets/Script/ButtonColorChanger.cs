using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColorChanger : MonoBehaviour
{
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
    }

    public void SetButtonColorGreen()
    {
        if (button != null)
        {
            ColorBlock cb = button.colors;
            cb.normalColor = Color.green;
            cb.highlightedColor = Color.green;
            cb.pressedColor = Color.green;
            cb.selectedColor = Color.green;
            button.colors = cb;
        }
    }
}
