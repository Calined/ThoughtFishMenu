using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TouchToRay : MonoBehaviour
{
    public EventSystem myEventSystem;

    Physics2DRaycaster m_Raycaster;
    PointerEventData m_PointerEventData;

    void Start()
    {
        m_Raycaster = GetComponent<Physics2DRaycaster>();

    }

    // Update is called once per frame
    void Update()
    {



        m_PointerEventData = new PointerEventData(myEventSystem);
        m_PointerEventData.position = Input.mousePosition;
        List<RaycastResult> results = new List<RaycastResult>();

        m_Raycaster.Raycast(m_PointerEventData, results);



        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonUp(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonUp(1))
        {

            bool unitWasSelected = false;

            foreach (RaycastResult result in results)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    result.gameObject.GetComponent<Unit>().LeftDown();
                }
                if (Input.GetMouseButtonUp(0))
                {
                    if (result.gameObject.GetComponent<Unit>())
                    { unitWasSelected = true; }

                    result.gameObject.GetComponent<Unit>().LeftUp();
                }
                if (Input.GetMouseButtonDown(1))
                {
                    result.gameObject.GetComponent<Unit>().RightDown();
                }
                if (Input.GetMouseButtonUp(1))
                {
                    result.gameObject.GetComponent<Unit>().RightUp();
                }

            }

            if (!unitWasSelected && Manager.manager.currentlySelectedUnit)
            {
                Manager.manager.DeselectUnit();
            }


        }


    }


}

