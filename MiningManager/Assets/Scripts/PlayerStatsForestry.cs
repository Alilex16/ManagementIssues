using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayerStatsForestry : MonoBehaviour {


    [Header("Logs Texts")]
    public Text logPineText;
    public Text logOakText;
    public Text logSpruceText;
    public Text logWillowText;
    public Text logFirText;
    public Text logCherryText;
    public Text logMahoganyText;
    public Text logElderText;

    [Header("Treated Wood Texts")]
    public Text treatedSoftwoodText;
    public Text treatedHardwoodText;
    public Text treatedDensewoodText;

    [Header("All Logs")] // Remove flat extra // testing purposes
    public static float logPineAmount = 5000;
    public static float logOakAmount = 5000;
    public static float logSpruceAmount = 5000;
    public static float logWillowAmount = 5000;
    public static float logFirAmount = 5000;
    public static float logCherryAmount = 5000;
    public static float logMahoganyAmount = 5000;
    public static float logElderAmount = 5000;

    [Header("All Treated Wood")]
    public static float treatedSoftwoodAmount = 5000;
    public static float treatedHardwoodAmount = 5000;
    public static float treatedDensewoodAmount = 5000;

    [Header("Trees Rarity")] // the higher the more rare. 1-100. 1=1/1. 100=1/100. (Check each second)
    public static int rarityPine = 2; // 1/2 = 50%
    public static int rarityOak = 3; // 1/3 = 33%
    public static int raritySpruce = 4; // 1/4 = 25%
    public static int rarityWillow = 5;
    public static int rarityFir = 8;
    public static int rarityCherry = 12;
    public static int rarityMahogany = 25;
    public static int rarityElder = 50;

    [Header("Modifiers")]
    private float randomizer;
    private float r_Speed;
    private float r_Strength;
    
    [Header("Routes Amount of Employees")]
    private float getLogsRoute01;
    private float getLogsRoute02;
    private float getLogsRoute03;
    private float getLogsRoute04;
    private float getLogsRoute05;
    private float getLogsRoute06;
    
    [Header("Routes Speed")]
    public static float route02Speed;
    public static float route03Speed;
    public static float route04Speed;
    public static float route05Speed;
    public static float route06Speed;

    [Header("Routes Strength")]
    private float route02Strength;
    public static float route03Strength;
    public static float route04Strength;
    public static float route05Strength;
    public static float route06Strength;

    
    public float Route02Strength
    {
        get { return route02Strength; }
        set { route02Strength = value; }
    }


    public static PlayerStatsForestry instance;

    void Awake()
    {
        instance = this;
    }


    void FixedUpdate()
    {
        if (logPineAmount > 0) // Pine
        {
            logPineText.transform.parent.gameObject.SetActive(true); // if more than 1 is owned, sets parent visible

            if (logPineAmount < 100000)
            {
                logPineText.text = "" + logPineAmount.ToString("0");
            }
            else
            {
                float logPineAmountK;
                logPineAmountK = logPineAmount / 1000f;
                logPineText.text = logPineAmountK.ToString("0") + "K";
            }
        }
        else
        {
            logPineText.transform.parent.gameObject.SetActive(false); // if none is owned, sets parent invisible
        }


        if (logOakAmount > 0) // Oak
        {
            logOakText.transform.parent.gameObject.SetActive(true);

            if (logOakAmount < 100000)
            {
                logOakText.text = "" + logOakAmount.ToString("0");
            }
            else
            {
                float logOakAmountK;
                logOakAmountK = logOakAmount / 1000f;
                logOakText.text = logOakAmountK.ToString("0") + "K";
            }
        }
        else
        {
            logOakText.transform.parent.gameObject.SetActive(false);
        }

        if (logSpruceAmount > 0) // Spruce
        {
            logSpruceText.transform.parent.gameObject.SetActive(true);

            if (logSpruceAmount < 100000)
            {
                logSpruceText.text = "" + logSpruceAmount.ToString("0");
            }
            else
            {
                float logSpruceAmountK;
                logSpruceAmountK = logSpruceAmount / 1000f;
                logSpruceText.text = logSpruceAmountK.ToString("0") + "K";
            }
        }
        else
        {
            logSpruceText.transform.parent.gameObject.SetActive(false);
        }

        if (logWillowAmount > 0) // Willow
        {
            logWillowText.transform.parent.gameObject.SetActive(true);

            if (logWillowAmount < 100000)
            {
                logWillowText.text = "" + logWillowAmount.ToString("0");
            }
            else
            {
                float logWillowAmountK;
                logWillowAmountK = logWillowAmount / 1000f;
                logWillowText.text = logWillowAmountK.ToString("0") + "K";
            }
        }
        else
        {
            logWillowText.transform.parent.gameObject.SetActive(false);
        }

        if (logFirAmount > 0) // Fir
        {
            logFirText.transform.parent.gameObject.SetActive(true);

            if (logFirAmount < 100000)
            {
                logFirText.text = "" + logFirAmount.ToString("0");
            }
            else
            {
                float logFirAmountK;
                logFirAmountK = logFirAmount / 1000f;
                logFirText.text = logFirAmountK.ToString("0") + "K";
            }
        }
        else
        {
            logFirText.transform.parent.gameObject.SetActive(false);
        }

        if (logCherryAmount > 0) // Cherry
        {
            logCherryText.transform.parent.gameObject.SetActive(true);

            if (logCherryAmount < 100000)
            {
                logCherryText.text = "" + logCherryAmount.ToString("0");
            }
            else
            {
                float logCherryAmountK;
                logCherryAmountK = logCherryAmount / 1000f;
                logCherryText.text = logCherryAmountK.ToString("0") + "K";
            }
        }
        else
        {
            logCherryText.transform.parent.gameObject.SetActive(false);
        }

        if (logMahoganyAmount > 0) // Mahogany
        {
            logMahoganyText.transform.parent.gameObject.SetActive(true);

            if (logMahoganyAmount < 100000)
            {
                logMahoganyText.text = "" + logMahoganyAmount.ToString("0");
            }
            else
            {
                float logMahoganyAmountK;
                logMahoganyAmountK = logMahoganyAmount / 1000f;
                logMahoganyText.text = logMahoganyAmountK.ToString("0") + "K";
            }
        }
        else
        {
            logMahoganyText.transform.parent.gameObject.SetActive(false);
        }

        if (logElderAmount > 0) // Elder
        {
            logElderText.transform.parent.gameObject.SetActive(true);

            if (logElderAmount < 100000)
            {
                logElderText.text = "" + logElderAmount.ToString("0");
            }
            else
            {
                float logElderAmountK;
                logElderAmountK = logElderAmount / 1000f;
                logElderText.text = logElderAmountK.ToString("0") + "K";
            }
        }
        else
        {
            logElderText.transform.parent.gameObject.SetActive(false);
        }


        if (treatedSoftwoodAmount > 0) // Treated Softwood
        {
            treatedSoftwoodText.transform.parent.gameObject.SetActive(true);

            if (treatedSoftwoodAmount < 100000)
            {
                treatedSoftwoodText.text = "" + treatedSoftwoodAmount.ToString("0");
            }
            else
            {
                float treatedSoftwoodAmountK;
                treatedSoftwoodAmountK = treatedSoftwoodAmount / 1000f;
                treatedSoftwoodText.text = treatedSoftwoodAmountK.ToString("0") + "K";
            }
        }
        else
        {
            treatedSoftwoodText.transform.parent.gameObject.SetActive(false);
        }

        if (treatedHardwoodAmount > 0) // Treated Hardwood
        {
            treatedHardwoodText.transform.parent.gameObject.SetActive(true);

            if (treatedHardwoodAmount < 100000)
            {
                treatedHardwoodText.text = "" + treatedHardwoodAmount.ToString("0");
            }
            else
            {
                float treatedHardwoodAmountK;
                treatedHardwoodAmountK = treatedHardwoodAmount / 1000f;
                treatedHardwoodText.text = treatedHardwoodAmountK.ToString("0") + "K";
            }
        }
        else
        {
            treatedHardwoodText.transform.parent.gameObject.SetActive(false);
        }

        if (treatedDensewoodAmount > 0) // Treated Densewood
        {
            treatedDensewoodText.transform.parent.gameObject.SetActive(true);

            if (treatedDensewoodAmount < 100000)
            {
                treatedDensewoodText.text = "" + treatedDensewoodAmount.ToString("0");
            }
            else
            {
                float treatedDensewoodAmountK;
                treatedDensewoodAmountK = treatedDensewoodAmount / 1000f;
                treatedDensewoodText.text = treatedDensewoodAmountK.ToString("0") + "K";
            }
        }
        else
        {
            treatedDensewoodText.transform.parent.gameObject.SetActive(false);
        }


        randomizer = 0.8f * Random.Range(0.8f, 1.2f) + Random.Range(0.0f, 0.2f) - Random.Range(0.0f, 0.2f);
        r_Speed = Random.Range(0.8f, 1.2f); // Seperate random numbers per route? per mineral?
        r_Strength = Random.Range(0.8f, 1.2f);
        
        getLogsRoute01 += Time.deltaTime * StartMining.forestryRoute01 * r_Speed; // time * amount of people. More people increase the gathering speed
        getLogsRoute02 += Time.deltaTime * (1 + (route02Speed * 0.05f)) * r_Speed; // per 1 speed, increases speed by 5%
        getLogsRoute03 += Time.deltaTime * (1 + (route03Speed * 0.05f)) * r_Speed;
        getLogsRoute04 += Time.deltaTime * (1 + (route04Speed * 0.05f)) * r_Speed;
        getLogsRoute05 += Time.deltaTime * (1 + (route05Speed * 0.05f)) * r_Speed;
        getLogsRoute06 += Time.deltaTime * (1 + (route06Speed * 0.05f)) * r_Speed;
        
        //calculate gathering speed, for each different log, and attach that to a timer (speed)
        //if timer reaches 0, set a chance to get the log or not (experience/specialty). The rarer the log, the lesser chance to get it.
        //The amount for gathering is always 1 (chopping depends on Strength)

        if (StartMining.forestryRoute01 > 0 && getLogsRoute01 >= 1) //if gathering wood & checks once per second
        {
            //Keep inside if statement, or ourside? 
            int ratePine = Random.Range(0, rarityPine);
            int rateOak = Random.Range(0, rarityOak);
            int rateSpruce = Random.Range(0, raritySpruce);
            int rateWillow = Random.Range(0, rarityWillow);
            int rateFir = Random.Range(0, rarityFir);
            int rateCherry = Random.Range(0, rarityCherry);
            int rateMahogany = Random.Range(0, rarityMahogany);
            int rateElder = Random.Range(0, rarityElder);
            
            float totalGained = r_Strength * randomizer * Time.timeScale; // remove Time.timeScale? add a slight bonus when gathering with more people?
            
            if (ratePine == 1)
            {
                logPineAmount += totalGained;
            }

            if (rateOak == 1)
            {
                logOakAmount += totalGained;
            }

            if (rateSpruce == 1)
            {
                logSpruceAmount += totalGained;
            }

            if (rateWillow == 1)
            {
                logWillowAmount += totalGained;
            }

            if (rateFir == 1)
            {
                logFirAmount += totalGained;
            }

            if (rateCherry == 1)
            {
                logCherryAmount += totalGained;
            }
            
            if (rateMahogany == 1)
            {
                logMahoganyAmount += totalGained;
            }

            if (rateElder == 1)
            {
                logElderAmount += totalGained;
            }

            //chance to find plants or seeds

            getLogsRoute01 = 0;
        }

        
        if (StartMining.forestryRoute02 > 0 && getLogsRoute02 >= 1) // if at least 1 person is using this Route & checks once per second per persons working this route
        {
            int ratePine = Random.Range(0, rarityPine);
            int rateOak = Random.Range(0, rarityOak);
            int rateSpruce = Random.Range(0, raritySpruce);
            int rateCherry = Random.Range(0, rarityCherry);

            float calcPineGain = 1 + (route02Strength / 20); // Now, you get 5% more per Strength  //1 + ((route02Strength / rarityPine) / 100);
            float calcOakGain = 1 + (route02Strength / 20);
            float calcSpruceGain = 1 + (route02Strength / 20);
            float calcCherryGain = 1 + (route02Strength / 20);

            float totalGained = r_Strength * randomizer * Time.timeScale;

            if (ratePine == 1)
            {
                logPineAmount += calcPineGain * totalGained;
            }
            if (rateOak == 1)
            {
                logOakAmount += calcOakGain * totalGained;
            }
            if (rateSpruce == 1)
            {
                logSpruceAmount += calcSpruceGain * totalGained;
            }
            if (rateCherry == 1)
            {
                logCherryAmount += calcCherryGain * totalGained;
            }
            
            getLogsRoute02 = 0;
        }

        if (StartMining.forestryRoute03 > 0 && getLogsRoute03 >= 1)
        {
            int rateSpruce = Random.Range(0, raritySpruce);
            int rateFir = Random.Range(0, rarityFir);
            int rateMahogany = Random.Range(0, rarityMahogany);

            float calcSpruceGain = 1 + (route03Strength / 20);
            float calcFirGain = 1 + (route03Strength / 20);
            float calcMahoganyGain = 1 + (route03Strength / 20);

            float totalGained = r_Strength * randomizer * Time.timeScale;
            
            if (rateSpruce == 1)
            {
                logSpruceAmount += calcSpruceGain * totalGained;
            }
            if (rateFir == 1)
            {
                logFirAmount += calcFirGain * totalGained;
            }
            if (rateMahogany == 1)
            {
                logMahoganyAmount += calcMahoganyGain * totalGained;
            }

            getLogsRoute03 = 0;
        }

        if (StartMining.forestryRoute04 > 0 && getLogsRoute04 >= 1)
        {
            int rateWilow = Random.Range(0, rarityWillow);
            int rateFir = Random.Range(0, rarityFir);
            int rateElder = Random.Range(0, rarityElder);

            float calcWillowGain = 1 + (route04Strength / 20);
            float calcFirGain = 1 + (route04Strength / 20);
            float calcElderGain = 1 + (route04Strength / 20);

            float totalGained = r_Strength * randomizer * Time.timeScale;

            if (rateWilow == 1)
            {
                logWillowAmount += calcWillowGain * totalGained;
            }
            if (rateFir == 1)
            {
                logFirAmount += calcFirGain * totalGained;
            }
            if (rateElder == 1)
            {
                logElderAmount += calcElderGain * totalGained;
            }

            getLogsRoute04 = 0;
        }

        if (StartMining.forestryRoute05 > 0 && getLogsRoute05 >= 1)
        {
            int ratePine = Random.Range(0, rarityPine);
            int rateCherry = Random.Range(0, rarityCherry);
            int rateElder = Random.Range(0, rarityElder);

            float calcPineGain = 1 + (route05Strength / 20);
            float calcCherryGain = 1 + (route05Strength / 20);
            float calcElderGain = 1 + (route05Strength / 20);

            float totalGained = r_Strength * randomizer * Time.timeScale;

            if (ratePine == 1)
            {
                logPineAmount += calcPineGain * totalGained;
            }
            if (rateCherry == 1)
            {
                logCherryAmount += calcCherryGain * totalGained;
            }
            if (rateElder == 1)
            {
                logElderAmount += calcElderGain * totalGained;
            }

            getLogsRoute05 = 0;
        }

        if (StartMining.forestryRoute06 > 0 && getLogsRoute06 >= 1)
        {
            int rateOak = Random.Range(0, rarityOak);
            int rateWilow = Random.Range(0, rarityWillow);
            int rateMahogany = Random.Range(0, rarityMahogany);

            float calcOakGain = 1 + (route06Strength / 20);
            float calcWillowGain = 1 + (route06Strength / 20);
            float calcMahoganyGain = 1 + (route06Strength / 20);

            float totalGained = r_Strength * randomizer * Time.timeScale;

            if (rateOak == 1)
            {
                logOakAmount += calcOakGain * totalGained;
            }
            if (rateWilow == 1)
            {
                logWillowAmount += calcWillowGain * totalGained;
            }
            if (rateMahogany == 1)
            {
                logMahoganyAmount += calcMahoganyGain * totalGained;
            }
            // Chance to gain birdnest with seeds
            getLogsRoute06 = 0;
        }
    }
}
