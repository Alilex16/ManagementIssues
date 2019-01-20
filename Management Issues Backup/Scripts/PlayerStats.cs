using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public Text euroAmountText;
    public static float totalEuroAmount;

    public static int employeesHired;
    public Text employeesHiredText;


    public GameObject employeeManager;

    [Header("Ore Texts")]
    public Text oreRocksText;
    public Text oreIronText;
    public Text oreCoalText;
    public Text oreTinText;
    public Text oreCopperText;
    public Text oreLeadText;
    public Text oreSilverText;
    public Text oreZincText;
    public Text oreGoldText;
    public Text oreTitaniumText;
    public Text oreUraniumText;
    
    [Header("Gems Texts")]
    public Text gemSapphireText;
    public Text gemRubyText;
    public Text gemDiamondText;
    public Text gemPhosylliteText;
    public Text gemSphaleriteText;
    public Text gemBerylText;
    public Text gemMalachiteText;
    public Text gemAndalusiteText;
    
    [Header("Ingot Texts")]
    public Text ingotIronText;
    public Text ingotTinText;
    public Text ingotCopperText;
    public Text ingotLeadText;
    public Text ingotSilverText;
    public Text ingotZincText;
    public Text ingotGoldText;
    public Text ingotTitaniumText;
    
    [Header("All Ores")]
    public static float oreRocksAmount;
    public static float oreIronAmount;
    public static float oreCoalAmount;
    public static float oreTinAmount;
    public static float oreCopperAmount;
    public static float oreLeadAmount;
    public static float oreSilverAmount;
    public static float oreZincAmount;
    public static float oreGoldAmount;
    public static float oreTitaniumAmount;
    public static float oreUraniumAmount;
    
    [Header("All Gems")]
    public static float gemSapphireAmount;
    public static float gemRubyAmount;
    public static float gemDiamondAmount;
    public static float gemPhosylliteAmount;
    public static float gemSphaleriteAmount;
    public static float gemBerylAmount;
    public static float gemMalachiteAmount;
    public static float gemAndalusiteAmount;
    
    [Header("All Ingots")]
    public static float ingotIronAmount;
    public static float ingotCoalAmount;
    public static float ingotTinAmount;
    public static float ingotCopperAmount;
    public static float ingotLeadAmount;
    public static float ingotSilverAmount;
    public static float ingotZincAmount;
    public static float ingotGoldAmount;
    public static float ingotTitaniumAmount;


    //public static int gemsEarthStart;
    //public static int gemsFireStart;
    //public static int gemsWaterStart;

    //public int startingTurrets = 1;
    //public static int totalTurrets; //amount of turrets allowed to build

    //public static int favorMax = 300;


    //public static int Lives;
    //public static int startLivesRecord;
    //public int startLives = 20; //min.10 , max.20


    //public static int highScore; //rounds survived/lives left/monsters killed/RP gathered/favor gained






   // [Header("Employee Info")]
   // public GameObject info01;
    //public GameObject info02;
    //public GameObject info03;
    //public GameObject info04;
   // public GameObject info05;
    ///public GameObject info06;
    //public GameObject info07;
    //public GameObject info08;
    //public GameObject info09;
    //public GameObject info10;
    //public GameObject info11;
    //public GameObject info12;
    //public GameObject info13;
    //public GameObject info14;

    //public void DeactivateEmployeesToHireList()
    ////{
    //    info01.SetActive(false);
    //    info02.SetActive(false);
    //    info03.SetActive(false);
    //    info04.SetActive(false);
    //    info05.SetActive(false);
    //    info06.SetActive(false);
    //    info07.SetActive(false);
    //    info08.SetActive(false);
    //    info09.SetActive(false);
    //    info10.SetActive(false);
    //    info11.SetActive(false);
    //    info12.SetActive(false);
    //    info13.SetActive(false);
    //    info14.SetActive(false);
    //}


    public static PlayerStats instance;

    void Awake()
    {
        instance = this;
    }


    void Start()
    {
        //earthAffinity = 0;
        //fireAffinity = 0;
        //waterAffinity = 0;

        //Lives = startLives;
        //startLivesRecord = startLives;
        //totalTurrets = startingTurrets;

        //gemsEarthAmount = HeadquarterManager.gemsEarthAmountStarting + 5; //remove + 5; only used for testing
        //gemsFireAmount = HeadquarterManager.gemsFireAmountStarting + 5; //remove + 5; only used for testing
        //gemsWaterAmount = HeadquarterManager.gemsWaterAmountStarting + 5; //remove + 5; only used for testing

        //gemsEarthStart = gemsEarthAmountStarting;
        //gemsFireStart = gemsFireAmountStarting;
        //gemsWaterStart = gemsWaterAmountStarting;

        //if below is not present, when restarting you keep the infused gems from last game
        oreRocksAmount = 0;
        oreIronAmount = 0;
        oreCoalAmount = 0;
        oreTinAmount = 0;
        oreCopperAmount = 0;
        oreLeadAmount = 0;
        oreSilverAmount = 0;
        oreZincAmount = 0;
        oreGoldAmount = 0;
        oreTitaniumAmount = 0;
        oreUraniumAmount = 0;
        //orePalladiumAmount = 0;
        

        totalEuroAmount = 6500;
    }

    private void FixedUpdate()
    {

        if (employeesHired == 0)
        {
            employeeManager.GetComponent<Button>().interactable = false;
        }
        else
        {
            employeeManager.GetComponent<Button>().interactable = true;
        }


        if (totalEuroAmount < 100000)
        {
            euroAmountText.text = "€ " + totalEuroAmount.ToString("0");
        }
        else
        {
            float totalEuroAmountK;
            totalEuroAmountK = totalEuroAmount / 1000f;
            euroAmountText.text = "€ " + totalEuroAmountK.ToString("0") + "K"; // add a hovering text to show "Amount of Euros"
        }




        if (oreRocksAmount > 0)
        {
            oreRocksText.transform.parent.gameObject.SetActive(true); // if more than 1 is owned, sets parent visible

            if (oreRocksAmount < 100000)
            {
                oreRocksText.text = "" + oreRocksAmount.ToString("0"); // add a hovering text to show "Rocks"
            }
            else
            {
                float oreRocksAmountK;
                oreRocksAmountK = oreRocksAmount / 1000f;
                oreRocksText.text = oreRocksAmountK.ToString("0") + "K"; // add a hovering text to show "Rocks"
            }
        }
        else
        {
            oreRocksText.transform.parent.gameObject.SetActive(false); // if none is owned, sets parent invisible
        }



        if (oreIronAmount > 0)
        {
            oreIronText.transform.parent.gameObject.SetActive(true); // if more than 1 is owned, sets parent visible
        }
        else
        {
            oreIronText.transform.parent.gameObject.SetActive(false); // if none is owned, sets parent invisible
        }

        if (oreIronAmount < 100000)
        {
            oreIronText.text = "" + oreIronAmount.ToString("0"); //" Iron: \n"
        }
        else
        {
            float oreIronAmountK;
            oreIronAmountK = oreIronAmount / 1000f;
            oreIronText.text = oreIronAmountK.ToString("0") + "K";
        }




        if (oreCoalAmount > 0)
        {
            oreCoalText.transform.parent.gameObject.SetActive(true); // if more than 1 is owned, sets parent visible
        }
        else
        {
            oreCoalText.transform.parent.gameObject.SetActive(false); // if none is owned, sets parent invisible
        }

        if (oreCoalAmount < 100000)
        {
            oreCoalText.text = "" + oreCoalAmount.ToString("0"); //" Iron: \n"
        }
        else
        {
            float oreCoalAmountK;
            oreCoalAmountK = oreCoalAmount / 1000f;
            oreCoalText.text = oreCoalAmountK.ToString("0") + "K";
        }



        if (oreTinAmount > 0)
        {
            oreTinText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            oreTinText.transform.parent.gameObject.SetActive(false);
        }

        if (oreTinAmount < 100000)
        {
            oreTinText.text = "" + oreTinAmount.ToString("0");
        }
        else
        {
            float oreTinAmountK;
            oreTinAmountK = oreTinAmount / 1000f;
            oreTinText.text = oreTinAmountK.ToString("0") + "K";
        }



        if (oreCopperAmount > 0)
        {
            oreCopperText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            oreCopperText.transform.parent.gameObject.SetActive(false);
        }

        if (oreCopperAmount < 100000)
        {
            oreCopperText.text = "" + oreCopperAmount.ToString("0");
        }
        else
        {
            float oreCopperAmountK;
            oreCopperAmountK = oreCopperAmount / 1000f;
            oreCopperText.text = oreCopperAmountK.ToString("0") + "K";
        }



        if (oreLeadAmount > 0)
        {
            oreLeadText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            oreLeadText.transform.parent.gameObject.SetActive(false);
        }

        if (oreLeadAmount < 100000)
        {
            oreLeadText.text = "" + oreLeadAmount.ToString("0");
        }
        else
        {
            float oreLeadAmountK;
            oreLeadAmountK = oreLeadAmount / 1000f;
            oreLeadText.text = oreLeadAmountK.ToString("0") + "K";
        }



        if (oreSilverAmount > 0)
        {
            oreSilverText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            oreSilverText.transform.parent.gameObject.SetActive(false);
        }

        if (oreSilverAmount < 100000)
        {
            oreSilverText.text = "" + oreSilverAmount.ToString("0"); //" Iron: \n"
        }
        else
        {
            float oreSilverAmountK;
            oreSilverAmountK = oreSilverAmount / 1000f;
            oreSilverText.text = oreSilverAmountK.ToString("0") + "K";
        }


        if (oreZincAmount > 0)
        {
            oreZincText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            oreZincText.transform.parent.gameObject.SetActive(false);
        }

        if (oreZincAmount < 100000)
        {
            oreZincText.text = "" + oreZincAmount.ToString("0"); //" Iron: \n"
        }
        else
        {
            float oreZincAmountK;
            oreZincAmountK = oreZincAmount / 1000f;
            oreZincText.text = oreZincAmountK.ToString("0") + "K";
        }



        if (oreGoldAmount > 0)
        {
            oreGoldText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            oreGoldText.transform.parent.gameObject.SetActive(false);
        }

        if (oreGoldAmount < 100000)
        {
            oreGoldText.text = "" + oreGoldAmount.ToString("0"); //" Iron: \n"
        }
        else
        {
            float oreGoldAmountK;
            oreGoldAmountK = oreGoldAmount / 1000f;
            oreGoldText.text = oreGoldAmountK.ToString("0") + "K";
        }


        if (oreTitaniumAmount > 0)
        {
            oreTitaniumText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            oreTitaniumText.transform.parent.gameObject.SetActive(false);
        }

        if (oreTitaniumAmount < 100000)
        {
            oreTitaniumText.text = "" + oreTitaniumAmount.ToString("0"); //" Iron: \n"
        }
        else
        {
            float oreTitaniumAmountK;
            oreTitaniumAmountK = oreTitaniumAmount / 1000f;
            oreTitaniumText.text = oreTitaniumAmountK.ToString("0") + "K";
        }


        if (oreUraniumAmount > 0)
        {
            oreUraniumText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            oreUraniumText.transform.parent.gameObject.SetActive(false);
        }

        if (oreUraniumAmount < 100000)
        {
            oreUraniumText.text = "" + oreUraniumAmount.ToString("0"); //" Iron: \n"
        }
        else
        {
            float oreUraniumAmountK;
            oreUraniumAmountK = oreUraniumAmount / 1000f;
            oreUraniumText.text = oreUraniumAmountK.ToString("0") + "K";
        }

        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


        gemSapphireText.text = "" + gemSapphireAmount.ToString("0");
        
        if (gemSapphireAmount > 0)
        {
            gemSapphireText.transform.parent.gameObject.SetActive(true); // if more than 1 is owned, sets parent visible
        }
        else
        {
            gemSapphireText.transform.parent.gameObject.SetActive(false); // if none is owned, sets parent invisible
        }

        gemRubyText.text = "" + gemRubyAmount.ToString("0");

        if (gemRubyAmount > 0)
        {
            gemRubyText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            gemRubyText.transform.parent.gameObject.SetActive(false);
        }

        gemDiamondText.text = "" + gemDiamondAmount.ToString("0");

        if (gemDiamondAmount > 0)
        {
            gemDiamondText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            gemDiamondText.transform.parent.gameObject.SetActive(false);
        }

        gemPhosylliteText.text = "" + gemPhosylliteAmount.ToString("0");

        if (gemPhosylliteAmount > 0)
        {
            gemPhosylliteText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            gemPhosylliteText.transform.parent.gameObject.SetActive(false);
        }

        gemSphaleriteText.text = "" + gemSphaleriteAmount.ToString("0");

        if (gemSphaleriteAmount > 0)
        {
            gemSphaleriteText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            gemSphaleriteText.transform.parent.gameObject.SetActive(false);
        }

        gemBerylText.text = "" + gemBerylAmount.ToString("0");

        if (gemBerylAmount > 0)
        {
            gemBerylText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            gemBerylText.transform.parent.gameObject.SetActive(false);
        }

        gemMalachiteText.text = "" + gemMalachiteAmount.ToString("0");

        if (gemMalachiteAmount > 0)
        {
            gemMalachiteText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            gemMalachiteText.transform.parent.gameObject.SetActive(false);
        }

        gemAndalusiteText.text = "" + gemAndalusiteAmount.ToString("0");

        if (gemAndalusiteAmount > 0)
        {
            gemAndalusiteText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            gemAndalusiteText.transform.parent.gameObject.SetActive(false);
        }




        //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



        if (ingotIronAmount > 0)
        {
            ingotIronText.transform.parent.gameObject.SetActive(true);

            if (ingotIronAmount < 100000)
            {
                ingotIronText.text = "" + ingotIronAmount.ToString("0"); //" Iron: \n"
            }
            else
            {
                float ingotIronAmountK;
                ingotIronAmountK = ingotIronAmount / 1000f;
                ingotIronText.text = ingotIronAmountK.ToString("0") + "K";
            }
        }
        else
        {
            ingotIronText.transform.parent.gameObject.SetActive(false);
        }


        if (ingotTinAmount > 0)
        {
            ingotTinText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            ingotTinText.transform.parent.gameObject.SetActive(false);
        }

        if (ingotTinAmount < 100000)
        {
            ingotTinText.text = "" + ingotTinAmount.ToString("0"); //" Iron: \n"
        }
        else
        {
            float ingotTinAmountK;
            ingotTinAmountK = ingotTinAmount / 1000f;
            ingotTinText.text = ingotTinAmountK.ToString("0") + "K";
        }


        if (ingotCopperAmount > 0)
        {
            ingotCopperText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            ingotCopperText.transform.parent.gameObject.SetActive(false);
        }

        if (ingotCopperAmount < 100000)
        {
            ingotCopperText.text = "" + ingotCopperAmount.ToString("0"); //" Iron: \n"
        }
        else
        {
            float ingotCopperAmountK;
            ingotCopperAmountK = ingotCopperAmount / 1000f;
            ingotCopperText.text = ingotCopperAmountK.ToString("0") + "K";
        }


        if (ingotLeadAmount > 0)
        {
            ingotLeadText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            ingotLeadText.transform.parent.gameObject.SetActive(false);
        }

        if (ingotLeadAmount < 100000)
        {
            ingotLeadText.text = "" + ingotLeadAmount.ToString("0"); //" Iron: \n"
        }
        else
        {
            float ingotLeadAmountK;
            ingotLeadAmountK = ingotLeadAmount / 1000f;
            ingotLeadText.text = ingotLeadAmountK.ToString("0") + "K";
        }


        if (ingotSilverAmount > 0)
        {
            ingotSilverText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            ingotSilverText.transform.parent.gameObject.SetActive(false);
        }

        if (ingotSilverAmount < 100000)
        {
            ingotSilverText.text = "" + ingotSilverAmount.ToString("0"); //" Iron: \n"
        }
        else
        {
            float ingotSilverAmountK;
            ingotSilverAmountK = ingotSilverAmount / 1000f;
            ingotSilverText.text = ingotSilverAmountK.ToString("0") + "K";
        }




        if (ingotZincAmount > 0)
        {
            ingotZincText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            ingotZincText.transform.parent.gameObject.SetActive(false);
        }

        if (ingotZincAmount < 100000)
        {
            ingotZincText.text = "" + ingotZincAmount.ToString("0"); //" Iron: \n"
        }
        else
        {
            float ingotZincAmountK;
            ingotZincAmountK = ingotZincAmount / 1000f;
            ingotZincText.text = ingotZincAmountK.ToString("0") + "K";
        }



        if (ingotGoldAmount > 0)
        {
            ingotGoldText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            ingotGoldText.transform.parent.gameObject.SetActive(false);
        }

        if (ingotGoldAmount < 100000)
        {
            ingotGoldText.text = "" + ingotGoldAmount.ToString("0"); //" Iron: \n"
        }
        else
        {
            float ingotGoldAmountK;
            ingotGoldAmountK = ingotGoldAmount / 1000f;
            ingotGoldText.text = ingotGoldAmountK.ToString("0") + "K";
        }



        if (ingotTitaniumAmount > 0)
        {
            ingotTitaniumText.transform.parent.gameObject.SetActive(true);
        }
        else
        {
            ingotTitaniumText.transform.parent.gameObject.SetActive(false);
        }

        if (ingotTitaniumAmount < 100000)
        {
            ingotTitaniumText.text = "" + ingotTitaniumAmount.ToString("0"); //" Iron: \n"
        }
        else
        {
            float ingotTitaniumAmountK;
            ingotTitaniumAmountK = ingotTitaniumAmount / 1000f;
            ingotTitaniumText.text = ingotTitaniumAmountK.ToString("0") + "K";
        }



        employeesHiredText.text = "Employees Hired: " + PlayerStats.employeesHired.ToString();


        timeScaleTotal = Time.timeScale * 0.8f * Random.Range(0.8f, 1.2f) + Random.Range(0.0f, 0.2f) - Random.Range(0.0f, 0.2f);
        r_Speed = Random.Range(1, 1.2f); // Seperate random numbers per route? per mineral?
        r_Strength = Random.Range(1, 1.2f);

        //Debug.Log(timeScaleTotal);

        

        searchGems += Time.deltaTime;

        if (searchGems >= 1)
        {
            //Debug.Log("gem check is done");
            searchGems = 0;
        }

        //Mathf.Floor(searchGems);


        if (gatheringStrengthRocks != 0 && gatheringSpeedRocks != 0)
        {
            //oreRocksAmount += 1f * employeesHired * (0.02f * Time.timeScale); // 2 per second per employee??
            //oreIronAmount += 0.1f * employeesHired * (0.02f * Time.timeScale); // 1 per second per employee??
            oreRocksAmount += timeScaleTotal * (((((((gatheringStrengthRocks * 4) * r_Strength) / 1000))) / hardnessRock) + ((((((gatheringSpeedRocks * 4) * r_Speed) / 1000)) - (hardnessRock / 1000)) / hardnessRock) * (1 + ((gatheringStrengthRocks * gatheringSpeedRocks) / 100))); // 2 per second per employee??
        }

        if (gatheringStrengthIron != 0 && gatheringSpeedIron != 0)
        {
            oreIronAmount += timeScaleTotal * ((((((gatheringStrengthIron * 4) * r_Strength) / 1000)) / hardnessIron) + ((((((gatheringSpeedIron * 4) * r_Speed) / 1000)) - (hardnessIron / 1000)) / hardnessIron) * (1 + ((gatheringStrengthIron * gatheringSpeedIron) / 100)));
            
            if (searchGems >= 0.98f)
            {
                GainRuby();
                GainDiamond();
                //Debug.Log("IRON check is done");
            }

        }
        

        if (gatheringStrengthCoal != 0 && gatheringSpeedCoal != 0)
        {
            oreCoalAmount += timeScaleTotal * ((((((gatheringStrengthCoal * 4) * r_Strength) / 1000)) / hardnessCoal) + ((((((gatheringSpeedCoal * 4) * r_Speed) / 1000)) - (hardnessCoal / 1000)) / hardnessCoal) * (1 + ((gatheringStrengthCoal * gatheringSpeedCoal) / 100)));

            if (searchGems >= 0.98f)
            {
                GainSapphire();
                GainDiamond();
                //Debug.Log("COAL check is done");
            }
        }
        
        if (gatheringStrengthTin != 0 && gatheringSpeedTin != 0)
        {
            oreTinAmount += timeScaleTotal * ((((((gatheringStrengthTin * 4) * r_Strength) / 1000)) / hardnessTin) + ((((((gatheringSpeedTin * 4) * r_Speed) / 1000)) - (hardnessTin / 1000)) / hardnessTin) * (1 + ((gatheringStrengthTin * gatheringSpeedTin) / 100)));
        }

        if (gatheringStrengthCopper != 0 && gatheringSpeedCopper != 0)
        {
            oreCopperAmount += timeScaleTotal * ((((((gatheringStrengthCopper * 4) * r_Strength) / 1000)) / hardnessCopper) + ((((((gatheringSpeedCopper * 4) * r_Speed) / 1000)) - (hardnessCopper / 1000)) / hardnessCopper) * (1 + ((gatheringStrengthCopper * gatheringSpeedCopper) / 100))); // 2 per second per employee??

            if (searchGems >= 0.98f)
            {
                GainMalachite();
            }
        }
        
        if (gatheringStrengthLead != 0 && gatheringSpeedLead != 0)
        {
            oreLeadAmount += timeScaleTotal * ((((((gatheringStrengthLead * 4) * r_Strength) / 1000)) / hardnessLead) + ((((((gatheringSpeedLead * 4) * r_Speed) / 1000)) - (hardnessLead / 1000)) / hardnessLead) * (1 + ((gatheringStrengthLead * gatheringSpeedLead) / 100)));

            if (searchGems >= 0.98f)
            {
                GainAndalusite();
            }
        }

        if (gatheringStrengthSilver != 0 && gatheringSpeedSilver != 0)
        {
            oreSilverAmount += timeScaleTotal * ((((((gatheringStrengthSilver * 4) * r_Strength) / 1000)) / hardnessSilver) + ((((((gatheringSpeedSilver * 4) * r_Speed) / 1000)) - (hardnessSilver / 1000)) / hardnessSilver) * (1 + ((gatheringStrengthSilver * gatheringSpeedSilver) / 100))); // 2 per second per employee??
        }
        
        if (gatheringStrengthZinc != 0 && gatheringSpeedZinc != 0)
        {
            oreZincAmount += timeScaleTotal * ((((((gatheringStrengthZinc * 4) * r_Strength) / 1000)) / hardnessZinc) + ((((((gatheringSpeedZinc * 4) * r_Speed) / 1000)) - (hardnessZinc / 1000)) / hardnessZinc) * (1 + ((gatheringStrengthZinc * gatheringSpeedZinc) / 100)));

            if (searchGems >= 0.98f)
            {
                GainPhosyllite();
                GainSphalerite();
            }
        }

        if (gatheringStrengthGold != 0 && gatheringSpeedGold != 0)
        {
            oreGoldAmount += timeScaleTotal * ((((((gatheringStrengthGold * 4) * r_Strength) / 1000)) / hardnessGold) + ((((((gatheringSpeedGold * 4) * r_Speed) / 1000)) - (hardnessGold / 1000)) / hardnessGold) * (1 + ((gatheringStrengthGold * gatheringSpeedGold) / 100))); // 2 per second per employee??
        }

        if (gatheringStrengthTitanium != 0 && gatheringSpeedTitanium != 0)
        {
            oreTitaniumAmount += timeScaleTotal * ((((((gatheringStrengthTitanium * 4) * r_Strength) / 1000)) / hardnessTitanium) + ((((((gatheringSpeedTitanium * 4) * r_Speed) / 1000)) - (hardnessTitanium / 1000)) / hardnessTitanium) * (1 + ((gatheringStrengthTitanium * gatheringSpeedTitanium) / 100)));

            if (searchGems >= 0.98f)
            {
                GainRuby();
                GainPhosyllite();
            }
        }
        
        if (gatheringStrengthUranium != 0 && gatheringSpeedUranium != 0)
        {
            oreUraniumAmount += timeScaleTotal * ((((((gatheringStrengthUranium * 4) * r_Strength) / 1000)) / hardnessUranium) + ((((((gatheringSpeedUranium * 4) * r_Speed) / 1000)) - (hardnessUranium / 1000)) / hardnessUranium) * (1 + ((gatheringStrengthUranium * gatheringSpeedUranium) / 100)));
            
            if (searchGems >= 0.98f)
            {
                GainBeryl();
            }
        }
        

    }

    private float searchGems; //



    public void GainSapphire()
    {
        findChanceSapphire = Random.Range(0, 3600); //chance 1 out of 3600. Is avarage once every 1 hours // originally, check is done 50 times per second

        if (findChanceSapphire == 1)
        {
            gemSapphireAmount += 1;
        }
    }

    public void GainRuby()
    {
        findChanceRuby = Random.Range(0, 7200); //chance 1 out of 7200. Is avarage once every 2 hours

        if (findChanceRuby == 1)
        {
            gemRubyAmount += 1;
        }
    }

    public void GainDiamond()
    {
        findChanceDiamond = Random.Range(0, 14400); //chance 1 out of 14400. Is avarage once every 4 hours

        //Debug.Log("Times checked " + findChanceDiamond); //searchGems.ToString("0.000"));

        if (findChanceDiamond == 1)
        {
            gemDiamondAmount += 1;
        }
    }

    public void GainPhosyllite()
    {
        findChancePhosyllite = Random.Range(0, 10800); //chance 1 out of 10800. Is avarage once every 3 hours

        if (findChancePhosyllite == 1)
        {
            gemPhosylliteAmount += 1;
        }
    }

    public void GainSphalerite()
    {
        findChanceSphalerite = Random.Range(0, 10800); //chance 1 out of 10800. Is avarage once every 3 hours

        if (findChanceSphalerite == 1)
        {
            gemSphaleriteAmount += 1;
        }
    }

    public void GainBeryl()
    {
        findChanceBeryl = Random.Range(0, 21600); //chance 1 out of 21600. Is avarage once every 6 hours

        if (findChanceBeryl == 1)
        {
            gemBerylAmount += 1;
        }
    }

    public void GainMalachite()
    {
        findChanceMalachite = Random.Range(0, 5400); //chance 1 out of 5400. Is avarage once every 1.5 hours

        if (findChanceMalachite == 1)
        {
            gemMalachiteAmount += 1;
        }
    }

    public void GainAndalusite()
    {
        findChanceAndalusite = Random.Range(0, 9000); //chance 1 out of 9000. Is avarage once every 2.5 hours

        if (findChanceAndalusite == 1)
        {
            gemAndalusiteAmount += 1;
        }
    }

    


    [Header("Gems find chance")]
    public static int findChanceSapphire;
    public static int findChanceRuby;
    public static int findChanceDiamond;
    public static int findChancePhosyllite;
    public static int findChanceSphalerite;
    public static int findChanceBeryl;
    public static int findChanceMalachite;
    public static int findChanceAndalusite;
    
    [Header("Modifiers")]
    private float timeScaleTotal;
    private float r_Speed;
    private float r_Strength;

    [Header("Hardness")]
    public static float hardnessRock = 1f;
    public static float hardnessIron = 4f;
    public static float hardnessCoal = 2f;
    public static float hardnessTin = 1.5f;
    public static float hardnessCopper = 3f;
    public static float hardnessLead = 1.5f;
    public static float hardnessSilver = 2.5f;
    public static float hardnessZinc = 3.5f; // 3??
    public static float hardnessGold = 2.5f;
    public static float hardnessTitanium = 6f;
    public static float hardnessUranium = 6f;
    
    [Header("Gather Speed")]
    public static float gatheringSpeedRocks;
    public static float gatheringSpeedIron;
    public static float gatheringSpeedCoal;
    public static float gatheringSpeedTin;
    public static float gatheringSpeedCopper;
    public static float gatheringSpeedLead;
    public static float gatheringSpeedSilver;
    public static float gatheringSpeedZinc;
    public static float gatheringSpeedGold;
    public static float gatheringSpeedTitanium;
    public static float gatheringSpeedUranium;
    
    [Header("Gather Strength")]
    public static float gatheringStrengthRocks;
    public static float gatheringStrengthIron;
    public static float gatheringStrengthCoal;
    public static float gatheringStrengthTin;
    public static float gatheringStrengthCopper;
    public static float gatheringStrengthLead;
    public static float gatheringStrengthSilver;
    public static float gatheringStrengthZinc;
    public static float gatheringStrengthGold;
    public static float gatheringStrengthTitanium;
    public static float gatheringStrengthUranium;

    

    public void HireEmployee()
    {
       employeesHired += 1;
    }

    public void FireEmployee()
    {
        employeesHired -= 1;
    }


    //public static EmployeeExtra a;
    [Header("Choose Route")]
    public GameObject chooseRoute;

    public void EmployeeDeselected()
    {
        //a.employeeSelectedBool = false;
        chooseRoute.GetComponent<Dropdown>().interactable = false;
    }



}
