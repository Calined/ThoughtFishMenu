using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoMenu : MonoBehaviour
{

    public void ShowUnitInfo(string unitInfo)
    {
        transform.GetChild(0).GetChild(0).GetComponent<TextMesh>().text = unitInfo;
    }


}
