using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Unit : MonoBehaviour
{
    public string unitInfo;

    public Material unitBaseMaterial;
    public Material unitSelectedMaterial;

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
        Select();
        ShowUnitInfo();
    }

    public void Select()
    {
        if (Manager.manager.currentlySelectedUnit)
        {
            Manager.manager.DeselectUnit();
        }

        Manager.manager.currentlySelectedUnit = this;

        GetComponent<SpriteRenderer>().material = unitSelectedMaterial;
    }

    public void Deselect()
    {
        GetComponent<SpriteRenderer>().material = unitBaseMaterial;
    }


    void ShowUnitInfo()
    {
        Manager.manager.infoMenu.ShowUnitInfo(unitInfo);
    }

    void RightClick()
    {
        ChangeColor();
    }

    void ChangeColor()
    {
        GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    void OnMouseDrag()
    {
        Vector2 dragPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));

        if (Vector2.Distance(dragStartPos, dragPos) > 0.2f)
        {

            leftWasDown = false;
            rightWasDown = false;

            Vector3 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + mouseOffset;
            transform.position = curPosition;
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
        Manager.manager.toolTip.ShowUnitInfo(unitInfo, transform.position);
    }

}
