using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : Button
{
    [SerializeField]
    private MainManager mainManager;
    [SerializeField]
    private Bar bar;
    
    public override void ButtonFunction() {
        bar.ToggleOnOff();
        mainManager.ButtonPress();
    }
}
