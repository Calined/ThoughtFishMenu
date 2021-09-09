using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoMenu : MonoBehaviour
{

    void ShowMenu()
    {
        transform.GetComponent<SpriteRenderer>().enabled = true;
        transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = true;
        transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().enabled = true;

    }

    void HideMenu()
    {
        transform.GetComponent<SpriteRenderer>().enabled = false;
        transform.GetChild(0).GetComponent<SpriteRenderer>().enabled = false;
        transform.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().enabled = false;

    }


    public void ShowUnitInfo(string unitInfo)
    {
        transform.GetChild(0).GetChild(0).GetComponent<TextMesh>().text = unitInfo;

        ShowMenu();
    }


}
