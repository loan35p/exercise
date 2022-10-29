using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    [SerializeField]
    private Button toggleButton;
    [SerializeField]
    private Text buttonText;
    private int buttonCounter = 0;
    [SerializeField]
    private Text switchText;
    private int switchCounter = 0;
    [SerializeField]
    private GameObject gameOverScreen;
    [SerializeField]
    private Button yesButton;
    [SerializeField]
    private Button noButton;
    [SerializeField]
    private Bar bar;
    [SerializeField]
    private Switch flipSwitch;
    [SerializeField]
    private GameObject quitScreen;
    [SerializeField]
    private GameObject mainCanvas;

    public void ButtonPress() {
        buttonCounter++;
        buttonText.text = buttonCounter.ToString();
        check();
    }

    public void SwitchFlip() {
        switchCounter++;
        switchText.text = switchCounter.ToString();
        check();
    }

    public void NewGame() {
        ResetButtons();
        flipSwitch.Activate();
        toggleButton.Activate();
        yesButton.Deactivate();
        noButton.Deactivate();
        bar.Reset();
        gameOverScreen.SetActive(false);
        buttonCounter = 0;
        switchCounter = 0;
        buttonText.text = buttonCounter.ToString();
        switchText.text = switchCounter.ToString();
    }

    public void Quit() {
        mainCanvas.SetActive(false);
        quitScreen.SetActive(true);
    }
    
    public void ResetButtons() {
        yesButton.Reset();
        noButton.Reset();
        toggleButton.Reset();
    }

    private void GameOver() {
        flipSwitch.Deactivate();
        toggleButton.Deactivate();
        yesButton.Activate();
        noButton.Activate();
        gameOverScreen.SetActive(true);
    }
    
    private void check() {
        if (buttonCounter + switchCounter > 9) {
            GameOver();
        }
    }

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            ResetButtons();
        }
    }
}
