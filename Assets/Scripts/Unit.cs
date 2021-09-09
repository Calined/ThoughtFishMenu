using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Unit : MonoBehaviour
{

    private Vector3 mouseOffset;

    private bool leftWasDown = false;
    private bool rightWasDown = false;

    public void LeftDown()
    {
        leftWasDown = true;
        mouseOffset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
    }

    public void LeftUp()
    {
        if (leftWasDown)
        {
            LeftClick();
            leftWasDown = false;
        }

    }

    public void RightDown()
    {
        rightWasDown = true;
    }

    public void RightUp()
    {
        if (rightWasDown)
        {
            RightClick();
            rightWasDown = false;
        }
    }

    void LeftClick()
    {
        Debug.Log("LeftClick");
    }

    void RightClick()
    {
        Debug.Log("RightClick");
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + mouseOffset;
        transform.position = curPosition;
    }

    void OnMouseExit()
    {
        leftWasDown = false;
        rightWasDown = false;
    }

}
