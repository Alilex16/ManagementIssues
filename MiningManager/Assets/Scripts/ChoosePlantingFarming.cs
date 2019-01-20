using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChoosePlantingFarming : MonoBehaviour, IPointerClickHandler
{
    public Image availableSeeds;
    public static Image availableSeedsStatic;
    public int patchNumber;
    public static int patchNumberStatic;


    private string seedName;
    private float plantingTime;
    private float growingTime;
    private float harvestingTime;
    private float harvestAmount;

    private Sprite originalSprite;
    //private Sprite growingSprite; // attach these to the seeds, as with the other stats // this will allow different sprites per seed // DO LATER
    public Sprite stage01;
    public Sprite stage02;
    public Sprite stage03;
    public Sprite stage04;

    //public List<GameObject> patchNumberList = new List<GameObject>();
    

    public static ChoosePlantingFarming instance;
    
    void Awake()
    {
        instance = this;

        //patchNumberList.Add(gameObject);
    }

    private void Start()
    {
        availableSeedsStatic = availableSeeds;

        originalSprite = GetComponent<Image>().sprite;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        patchNumberStatic = patchNumber;

        if (transform.childCount > 0)
        {
            // shows progress ?
            SeedInformation();

            // show not the base, but the current time
            Debug.Log("Plant Growing: " + seedName);
            Debug.Log("Planting Time Left: " + plantingTime);
            Debug.Log("Growing Time Left: " + growingTime);
            Debug.Log("Harvesting Time Left: " + harvestingTime);
            Debug.Log("harvest Amount: " + harvestAmount);
            
        }
        else
        {
            Debug.Log("this patch is empty");

            availableSeeds.gameObject.SetActive(true);
            PlayerStatsFarming.instance.DisableAllSeedUI();
            PlayerStatsFarming.instance.CheckSeedAmounts();
        }
    }

    private void Update() // runs once, when you planted a seed
    {
        if (SeedFruit.isPlanted) // && !isChecked)
        {
            SeedFruit.isPlanted = false;
            
            transform.gameObject.GetComponentInChildren<TooltipEnablerSeeds>().ToolTipDeactivate(); // deactivates the tooltip when planting a seed

            SeedInformation();

            SeedPlanting();

            SeedPlantingCost(); // removes the planted seed
        }
    }

    private void SeedInformation()
    {
        var seedNameObject = gameObject.transform.GetChild(0).GetChild(2);
        seedName = seedNameObject.GetComponentInChildren<Text>().text.ToString();

        var plantingTimeObject = gameObject.transform.GetChild(0).GetChild(5);
        plantingTime = float.Parse(plantingTimeObject.GetComponentInChildren<Text>().text.ToString());

        var growingTimeObject = gameObject.transform.GetChild(0).GetChild(6);
        growingTime = float.Parse(growingTimeObject.GetComponentInChildren<Text>().text.ToString());

        var harvestingTimeObject = gameObject.transform.GetChild(0).GetChild(7);
        harvestingTime = float.Parse(harvestingTimeObject.GetComponentInChildren<Text>().text.ToString());

        var harvestAmountObject = gameObject.transform.GetChild(0).GetChild(8);
        harvestAmount = float.Parse(harvestAmountObject.GetComponentInChildren<Text>().text.ToString());
    }


    private void SeedPlanting()
    {
        //int index = patchNumberList.IndexOf(patchNumberList[patchNumberStatic]);

        //Debug.Log(patchNumberStatic + " = " + index);
        
        Invoke("SeedGrowing", plantingTime);
    }
    
    private void SeedGrowing()
    {
        Invoke("GrowthStage01", growingTime * 0.25f);
    }

    private void GrowthStage01()
    {
        GetComponent<Image>().sprite = stage01;
        Invoke("GrowthStage02", growingTime * 0.25f); // 2nd growth stage // 50%
    }

    private void GrowthStage02()
    {
        GetComponent<Image>().sprite = stage02;
        Invoke("GrowthStage03", growingTime * 0.25f); // 3rd growth stage // 75%
    }

    private void GrowthStage03()
    {
        GetComponent<Image>().sprite = stage03;
        Invoke("GrowthStage04", growingTime * 0.25f); // final growth stage
    }

    private void GrowthStage04() //ReadyForHarvest()
    {
        GetComponent<Image>().sprite = stage04;

        Invoke("Harvesting", harvestingTime);
    }


    private void SeedPlantingCost()
    {
        if (transform.childCount > 0)
        {
            if (seedName == "Strawberry Seed")
            {
                PlayerStatsFarming.seedFruitStrawberryAmount -= 1;
            }
            if (seedName == "Blackberry Seed")
            {
                PlayerStatsFarming.seedFruitBlackberryAmount -= 1;
            }
            if (seedName == "Cyennaberry Seed")
            {
                PlayerStatsFarming.seedFruitCyennaberryAmount -= 1;
            }


            //add the rest
        }
    }


    private void Harvesting()
    {
        GetComponent<Image>().sprite = originalSprite;
        CancelInvoke();

        if (transform.childCount > 0)
        {
            if (seedName == "Strawberry Seed")
            {
                //var productName = "Strawberry";
                PlayerStatsFarming.productFruitStrawberryAmount += harvestAmount;
                //Debug.Log("Harvested " + harvestAmount + " pieces of " + productName);
            }
            if (seedName == "Blackberry Seed")
            {
                PlayerStatsFarming.productFruitBlackberryAmount += harvestAmount;
            }
            if (seedName == "Cyennaberry Seed")
            {
                PlayerStatsFarming.productFruitCyennaberryAmount += harvestAmount;
            }



            //add the rest




            Destroy(transform.GetChild(0).gameObject); // removes the child seed
        }
    }

}
