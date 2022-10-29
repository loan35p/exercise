using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YesButton : Button
{
    [SerializeField]
    private MainManager mainManager;

    public override void ButtonFunction() {
        mainManager.NewGame();
    }
}
