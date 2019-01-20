using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BlueprintPickaxe : MonoBehaviour, IPointerClickHandler
{
    private int tierPickaxe;
    
    public static int tierPickaxeShare; //unstatic?
    //public int tierPickaxeStat;
    //{
    //get { return tierPickaxeShare; }
    //protected set
    //{
    //    tierPickaxeShare = value;
    //}
    //}

    [SerializeField]
    private GameObject pickaxeBackground;

    [SerializeField]
    private GameObject nextTier; // if last of the tier is selected, insert this object
    
    private float material01RequirementsType;
    private float material02RequirementsType;

    private float material01RequirementsAmount;
    private float material02RequirementsAmount;
    
    public Text titleText;
    public Text descriptionText;
    public Image itemImage;

    public Image itemReq01Image;
    public Text itemReq01Amount;
    public Image itemReq02Image;
    public Text itemReq02Amount;

    private bool requirementMet;

    [SerializeField]
    private TierList TierPickaxe;




    public void OnPointerClick(PointerEventData eventData)
    {
        tierPickaxe = TierPickaxe.tierRank;
        MeetRequirement();
        //Debug.Log("Upgrade clicked.");
    }

    private void Start()
    {
        titleText.text = TierPickaxe.itemName.ToString();
        descriptionText.text = TierPickaxe.itemDescription.ToString();
        itemImage.GetComponent<Image>().sprite = TierPickaxe.itemIcon;
        itemReq01Image.GetComponent<Image>().sprite = TierPickaxe.itemReq01Icon;
        itemReq01Amount.text = TierPickaxe.itemReq01Amount.ToString();
        itemReq02Image.GetComponent<Image>().sprite = TierPickaxe.itemReq02Icon;
        itemReq02Amount.text = TierPickaxe.itemReq02Amount.ToString();
    }

    private void MeetRequirement()
    {
        //Debug.Log("tierPickaxe: " + tierPickaxe);

        SetRequirements();

        RequirementCheck();
    }

    private void SetRequirements()
    {
        if (tierPickaxe == 1) // wooden
        {
            material01RequirementsType = PlayerStatsForestry.treatedSoftwoodAmount;
            material02RequirementsType = PlayerStatsForestry.treatedHardwoodAmount;
            
            if (requirementMet)
            {
                PlayerStatsForestry.treatedSoftwoodAmount -= TierPickaxe.itemReq01Amount; // removes the items
                PlayerStatsForestry.treatedHardwoodAmount -= TierPickaxe.itemReq02Amount; // removes the items
                PostUpgrade();
            }
        }

        if (tierPickaxe == 2) // Lead
        {
            material01RequirementsType = PlayerStatsForestry.treatedSoftwoodAmount;
            material02RequirementsType = PlayerStats.ingotLeadAmount;

            if (requirementMet)
            {
                PlayerStatsForestry.treatedSoftwoodAmount -= TierPickaxe.itemReq01Amount;
                PlayerStats.ingotLeadAmount -= TierPickaxe.itemReq02Amount;
                PostUpgrade();
            }
        }

        if (tierPickaxe == 3) // Copper
        {
            material01RequirementsType = PlayerStatsForestry.treatedSoftwoodAmount;
            material02RequirementsType = PlayerStats.ingotCopperAmount;

            if (requirementMet)
            {
                PlayerStatsForestry.treatedSoftwoodAmount -= TierPickaxe.itemReq01Amount;
                PlayerStats.ingotCopperAmount -= TierPickaxe.itemReq02Amount;
                PostUpgrade();
            }
        }

        if (tierPickaxe == 4) // Iron
        {
            material01RequirementsType = PlayerStatsForestry.treatedHardwoodAmount;
            material02RequirementsType = PlayerStats.ingotIronAmount;

            if (requirementMet)
            {
                PlayerStatsForestry.treatedHardwoodAmount -= TierPickaxe.itemReq01Amount;
                PlayerStats.ingotIronAmount -= TierPickaxe.itemReq02Amount;
                PostUpgrade();
            }
        }

        if (tierPickaxe == 5) // Titanium
        {
            material01RequirementsType = PlayerStatsForestry.treatedDensewoodAmount;
            material02RequirementsType = PlayerStats.ingotTitaniumAmount;

            if (requirementMet)
            {
                PlayerStatsForestry.treatedDensewoodAmount -= TierPickaxe.itemReq01Amount;
                PlayerStats.ingotTitaniumAmount -= TierPickaxe.itemReq02Amount;
                PostUpgrade();
            }
        }
    }

    private void RequirementCheck()
    {
        if (material01RequirementsType > TierPickaxe.itemReq01Amount && material02RequirementsType > TierPickaxe.itemReq02Amount)
        {
            requirementMet = true;
            Invoke("SetRequirements", 0);
            
            //tierPickaxe += 1; // tier level up //not needed anymore
            
        }
        else
        {
            Debug.Log("Not enough resources.");
        }
    }

    private void PostUpgrade()
    {
        requirementMet = false;

        tierPickaxeShare = tierPickaxe; //able to set restrictions outside this script, based on tier

        Debug.Log("Tier Share: " + tierPickaxeShare);

        pickaxeBackground.GetComponent<Image>().sprite = TierPickaxe.itemIcon; // updates the icon
        
        nextTier.SetActive(true);  // enable next item
        gameObject.SetActive(false); // destroy instead of disable?? //DestroyObject(this);
    }
}