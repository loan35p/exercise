using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoButton : Button
{
    [SerializeField]
    private MainManager mainManager;

    public override void ButtonFunction() {
        mainManager.Quit();
    }
}
