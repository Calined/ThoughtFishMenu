using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTip : MonoBehaviour
{
    public void Show()
    {
        transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
        transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().enabled = true;
    }


    public void Hide()
    {
        transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
        transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().enabled = false;
    }


    public void ShowUnitInfo(string unitInfo, Vector2 unitPosition)
    {
        transform.GetChild(0).GetChild(0).GetComponent<TextMesh>().text = unitInfo;

        transform.position = unitPosition;

        Show();
    }

}
