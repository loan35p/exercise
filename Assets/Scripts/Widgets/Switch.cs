using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{
    [SerializeField]
    private MainManager mainManager;
    [SerializeField]
    private GameObject onState;
    [SerializeField]
    private GameObject offState;
    [SerializeField]
    private Bar bar;
    private float clickPos;
    private float lastToggle; 
    private bool isActive = true;
    private bool isFlipped = false;

    public void Deactivate() {
        isActive = false;
    }

    public void Activate() {
        isActive = true;
    }

    private void OnMouseDown() {
        clickPos = Input.mousePosition.y;
    }

    private void OnMouseUp() {
        if (Input.mousePosition.y - clickPos > 20 && isActive && !isFlipped) {
            onState.SetActive(false);
            offState.SetActive(true);
            lastToggle = Time.time;
            bar.ToggleDirection();
            mainManager.SwitchFlip();
            isFlipped = true;
        }
    }

    private void Update() {
        if (Time.time - lastToggle > 2.25) {
            onState.SetActive(true);
            offState.SetActive(false);
            isFlipped = false;
        }
    }
}