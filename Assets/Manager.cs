using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager manager;

    public InfoMenu infoMenu;

    // Start is called before the first frame update
    void Awake()
    {

        if (!manager)
        {
            manager = this;
        }

    }


}
