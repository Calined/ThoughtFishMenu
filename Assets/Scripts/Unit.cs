using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Unit : MonoBehaviour
{

    private Vector3 mouseOffset;

    public void LeftDown()
    {
        mouseOffset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
    }

    public void LeftUp()
    {

    }

    public void RightDown()
    {

    }

    public void RightUp()
    {

    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + mouseOffset;
        transform.position = curPosition;
    }

}
