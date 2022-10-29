using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    private bool isClicked = false;
    private bool isMouseOver = false;
    private bool isActive = true;
    [SerializeField]
    private Color defaultColor;
    [SerializeField]
    private Color hoveredColor;
    [SerializeField]
    private Color clickedColor;
    private Color targetColor;

    public virtual void ButtonFunction() {}

    public void Reset() {
        if (!isMouseOver) {
            targetColor = defaultColor;
            isClicked = false;
        }
    }

    public void Deactivate() {
        isActive = false;
        isMouseOver = false;
        this.GetComponent<Image>().color = defaultColor;
        Reset();
    }

    public void Activate() {
        isActive = true;
    }

    private void Awake() {
        this.GetComponent<Image>().color = defaultColor;
        targetColor = defaultColor;
    }

    private void Update() {
        if (isActive) {
            this.GetComponent<Image>().color = Color.Lerp(this.GetComponent<Image>().color, 
                targetColor, Constants.fadeSpeed * Time.deltaTime);
        }
    }

    private void OnMouseEnter()
    {
        isMouseOver = true;
        targetColor = hoveredColor;
    }

    private void OnMouseDown()
    {
        isClicked = true;
        targetColor = clickedColor;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
        if (!isClicked) {
            targetColor = defaultColor;
        }
    }

    private void OnMouseUp()
    {
        if (isMouseOver && isActive) {
            isClicked = false;
            ButtonFunction();
        }
        targetColor = hoveredColor;
    }
}
