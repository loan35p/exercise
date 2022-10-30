using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    private bool isRotating = false;
    // Always starts clockwise
    private int direction = -1;

    public void ToggleOnOff() {
        isRotating = !isRotating;
    }

    public void ToggleDirection() {
        direction *= -1;
    }

    public void Reset() {
        this.transform.rotation = new Quaternion(0, 0, 0, 0);
        direction = -1;
        isRotating = false;
    }

    private void Update()
    {
        if (isRotating) {
            // I measured 1 rotation every 3 seconds
            // 360/3 = 120 degrees/second
            this.transform.Rotate(0, 0, direction * 120 * Time.deltaTime);
        }
    }
}
