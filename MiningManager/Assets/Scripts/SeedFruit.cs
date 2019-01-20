using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SeedFruit : MonoBehaviour
{
    [SerializeField]
    private Seeds seeds;

    private Image seedsAvailable;

    public Text nameText;
    public Text descriptionText;
    public Text valueText;
    public Text plantingTime;
    public Text growingTime;
    public Text harvestingTime;
    public Text harvestAmount;

    public Button button;
    
    private float basePlantingTime;
    public float realPlantingTime; // just to make it visible

    public static bool isPlanted; 

    public static GameObject thisObject;
    

    private GameObject patch01Object;
    private GameObject patch02Object;
    private GameObject patch03Object;
    private GameObject patch04Object;
    private GameObject patch05Object;

    //public int seedNumber;

    //calculate the timings here. base=seeds.seed


    public static SeedFruit instance;

    void Awake()
    {
        instance = this;
    }
    
    private void OnEnable()
    {
        if (!isPlanted)
        {
            button.onClick.RemoveAllListeners(); // to make it stop calling multiple times

            button.onClick.AddListener(SeedChosen); // this is called multiple times???
            
        }
    }

    


    private void SeedChosen()
    {
        Debug.Log(seeds.seedName.ToString() + " Planted");
        
        seedsAvailable.gameObject.SetActive(false);

        isPlanted = true; //
        
        int patch = ChoosePlantingFarming.patchNumberStatic;

        thisObject = gameObject;

        GameObject copy = Instantiate(thisObject);

        //Destroy(copy.transform.GetChild(0).gameObject); //remove the background // make it disabled instead of removed
        //Destroy(copy.transform.GetChild(1).gameObject); //remove the button

        var backgroundImage = copy.gameObject.transform.GetChild(0);
        backgroundImage.gameObject.SetActive(false);
        var button = copy.gameObject.transform.GetChild(1);
        button.gameObject.SetActive(false);

        

        if (patch == 1)
        {
            copy.transform.SetParent(patch01Object.transform, false);
        }
        if (patch == 2)
        {
            copy.transform.SetParent(patch02Object.transform, false);
        }
        if (patch == 3)
        {
            copy.transform.SetParent(patch03Object.transform, false);
        }
        if (patch == 4)
        {
            copy.transform.SetParent(patch04Object.transform, false);
        }
        if (patch == 5)
        {
            copy.transform.SetParent(patch05Object.transform, false);
        }
        
    }

    private void Start()
    {
        patch01Object = GameObject.Find("FarmingBackground/Patch01");
        patch02Object = GameObject.Find("FarmingBackground/Patch02");
        patch03Object = GameObject.Find("FarmingBackground/Patch03");
        patch04Object = GameObject.Find("FarmingBackground/Patch04");
        patch05Object = GameObject.Find("FarmingBackground/Patch05");
        
        seedsAvailable = ChoosePlantingFarming.availableSeedsStatic;

        basePlantingTime = seeds.plantingTime;
        realPlantingTime = basePlantingTime; //implement formula


        
        ///base * + - etc;

        nameText.text = seeds.seedName.ToString();
        descriptionText.text = seeds.seedDescription.ToString();
        valueText.text = seeds.seedValue.ToString();
        plantingTime.text = seeds.plantingTime.ToString();
        growingTime.text = seeds.growingTime.ToString();
        harvestingTime.text = seeds.harvestingTime.ToString();
        harvestAmount.text = seeds.harvestAmount.ToString();
    }

}
