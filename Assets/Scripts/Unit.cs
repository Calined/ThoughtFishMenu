using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Unit : MonoBehaviour
{
    public string unitInfo;

    public Material unitBaseMaterial;
    public Material unitSelectedMaterial;


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


    public void ShowUnitInfo()
    {
        Manager.manager.infoMenu.ShowUnitInfo(unitInfo);
    }


    public void ChangeColor()
    {
        GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }


    public void ShowToolTip()
    {
        Manager.manager.toolTip.ShowUnitInfo(unitInfo, transform.position);
    }

}
