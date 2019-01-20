using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VisitSmithy : MonoBehaviour, IPointerClickHandler
{
    
    public GameObject inventory;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        //resets the position after hiring
        Vector3 pos = new Vector3(-336.3f, 19.274f, 0);

        inventory.transform.localPosition = pos;

    }
}
