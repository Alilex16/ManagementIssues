using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TooltipEnablerSeeds : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject toolTip;

    
    public void OnPointerEnter(PointerEventData eventData)
    {
        Invoke("ToolTipActivate", 0.2f); //after slight delay enable tooltip

        // instead of active/inactive, set alpha from 0 to 1?
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        ToolTipDeactivate();
    }

    public void ToolTipActivate()
    {
        var name = toolTip.gameObject.transform.GetChild(2);
        var description = toolTip.gameObject.transform.GetChild(3);
        var value = toolTip.gameObject.transform.GetChild(1).GetChild(0).gameObject;
        var plantingTime = toolTip.gameObject.transform.GetChild(4).GetChild(0).gameObject;
        var growingTime = toolTip.gameObject.transform.GetChild(4).GetChild(1).gameObject;
        var harvestingTime = toolTip.gameObject.transform.GetChild(4).GetChild(2).gameObject;
        var harvestAmount = toolTip.gameObject.transform.GetChild(4).GetChild(3).gameObject;


        var objectName = gameObject.name.ToString();
        var objectDescription = gameObject.transform.GetChild(3);
        var objectValue = gameObject.transform.GetChild(4);
        var objectPlantingTime = gameObject.transform.GetChild(5);
        var objectGrowingTime = gameObject.transform.GetChild(6);
        var objectHarvestingTime = gameObject.transform.GetChild(7);
        var objectHarvestAmount = gameObject.transform.GetChild(8);




        name.GetComponentInChildren<Text>().text = objectName; //SeedFruit.instance.nameText.text; //nameText.text; // SeedFruit. ????
        description.GetComponentInChildren<Text>().text = objectDescription.GetComponentInChildren<Text>().text;
        value.GetComponentInChildren<Text>().text = "€ " + objectValue.GetComponentInChildren<Text>().text; //SeedFruit.instance.valueText.text;
        plantingTime.GetComponentInChildren<Text>().text = "Planting Time: " + objectPlantingTime.GetComponentInChildren<Text>().text + " minutes";
        growingTime.GetComponentInChildren<Text>().text = "Growing Time: " + objectGrowingTime.GetComponentInChildren<Text>().text + " minutes";
        harvestingTime.GetComponentInChildren<Text>().text = "Harvesting Time: " + objectHarvestingTime.GetComponentInChildren<Text>().text + " minutes";
        harvestAmount.GetComponentInChildren<Text>().text = "Harvest Amount: " + objectHarvestAmount.GetComponentInChildren<Text>().text;
        

        //Debug.Log(gameObject.name.ToString());
        //gameObject.name.ToString();


        toolTip.SetActive(true);
    }

    public void ToolTipDeactivate()
    {
        toolTip.SetActive(false);
        CancelInvoke(); //disable tooltip
    }


}
