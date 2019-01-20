using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TooltipEnabler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject toolTip;
    public Text descriptionText;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Invoke("ToolTipActivate", 0.2f); //after slight delay enable tooltip

        //??instead of active/inactive, set alpha from 0 to 1
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        toolTip.SetActive(false);
        CancelInvoke(); //disable tooltiip
    }

    public void ToolTipActivate()
    {
        toolTip.GetComponentInChildren<Text>().text = descriptionText.text; //set the text to match description

        toolTip.SetActive(true);
    }


}
