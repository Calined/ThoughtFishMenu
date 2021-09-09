using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    [System.Serializable]
    public class MyEventType : UnityEvent { }

    public MyEventType OnLeftClick;
    public MyEventType OnRightClick;
    public MyEventType OnHover;

    public bool dragable = false;

    private Vector3 mouseOffset;

    private bool leftWasDown = false;
    private bool rightWasDown = false;

    private Vector2 dragStartPos;

    public void LeftDown()
    {
        leftWasDown = true;
        mouseOffset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        dragStartPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
    }

    public void LeftUp()
    {
        if (leftWasDown)
        {
            OnLeftClick.Invoke();
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
            OnRightClick.Invoke();
            rightWasDown = false;
        }
    }


    void OnMouseDrag()
    {
        if (dragable)
        {

            Vector2 dragPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));

            if (Vector2.Distance(dragStartPos, dragPos) > 0.2f)
            {
                Manager.manager.toolTip.Hide();

                leftWasDown = false;
                rightWasDown = false;

                Vector3 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
                Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + mouseOffset;
                transform.position = curPosition;
            }

        }
    }

    void OnMouseExit()
    {
        Manager.manager.toolTip.Hide();

        leftWasDown = false;
        rightWasDown = false;
    }

    void OnMouseEnter()
    {
        OnHover.Invoke();
    }

}
