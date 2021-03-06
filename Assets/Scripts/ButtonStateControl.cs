using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonStateControl : MonoBehaviour
{
    public enum ButtonType { JUMP, RUN, FALL };
    public ButtonType ButtonState;
    [SerializeField]
    GameObject[] Buttons;
    string ButtonName = "";

    void Update()
    {
        GetCurrentButtonName();
    }


    void GetCurrentButtonName()
    {
        for (int i = 0; i < Buttons.Length; i++)
        {
            if (Buttons[i].activeInHierarchy)
                ButtonName = Buttons[i].gameObject.name;
        }
    }
}
