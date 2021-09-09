using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

    private Vector3 mouseOffset;

    void OnMouseDown()
    {
        mouseOffset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + mouseOffset;
        transform.position = curPosition;
    }

}
