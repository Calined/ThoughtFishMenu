using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager manager;

    public InfoMenu infoMenu;

    public Unit currentlySelectedUnit;

    // Start is called before the first frame update
    void Awake()
    {

        if (!manager)
        {
            manager = this;
        }

    }

    public void DeselectUnit()
    {
        currentlySelectedUnit.Deselect();
        infoMenu.HideMenu();
    }

}
