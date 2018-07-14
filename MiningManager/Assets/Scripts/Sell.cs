using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Sell : MonoBehaviour
{

    public InputField inputfield;
    public Text text;
    
    private float amountToSell;

    //have these values rememberd on the object itself?
    private float oreRocksValue = 1;
    private float oreIronValue = 2;
    private float oreCoalValue = 2;
    private float oreTinValue = 2;
    private float oreCopperValue = 2;
    private float oreLeadValue = 3;
    private float oreSilverValue = 5;
    private float oreZincValue = 4;
    private float oreGoldValue = 8;
    private float oreTitaniumValue = 13;
    private float oreUraniumValue = 20;

    private float logPineValue = 1;
    private float logOakValue = 1;
    private float logSpruceValue = 2;
    private float logWillowValue = 5;
    private float logFirValue = 6;
    private float logCherryValue = 10;
    private float logMahoganyValue = 14;
    private float logElderValue = 25;
    
    //Add a function when hovering with your mouse over an ore, you can sell X amount by pressing the numbers 1/2/3/../9
    //Add a Right-Click function to sell: 10 / 50 / 100 / 1000


    public static Sell instance;

    void Awake()
    {
        instance = this;
    }


    public void SellStuff()
    {
        float.TryParse(inputfield.text, out amountToSell);
    }

    public void ResetInputField()
    {
        GetComponent<InputField>().text = ""; // so it will not remember any previous input
    }

    public void Selling()
    {
        if (Ores.oreNumberStatic == 1) // Rocks
        {
            if (PlayerStats.oreRocksAmount >= amountToSell && amountToSell > 0) //make sure you have enough rocks to sell and amount entered is not in the negative
            {
                PlayerStats.totalEuroAmount += amountToSell * oreRocksValue;
                PlayerStats.oreRocksAmount -= amountToSell; // 0;
            }
            else
            {
                //Debug.Log("You don't have enough Rocks to sell.");
                //amountToSell = PlayerStats.oreRocksAmount; //sets the amount to sell, to the max you own // doesn't work properly (value gets remembered, but not updated as amountToSell)
                //PlayerStats.totalEuroAmount += amountToSell * oreRocksValue; //
                //PlayerStats.oreRocksAmount -= amountToSell; // 0;
            }
        }

        if (Ores.oreNumberStatic == 2) // Iron
        {
            if (PlayerStats.oreIronAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * oreIronValue;
                PlayerStats.oreIronAmount -= amountToSell;
            }
        }

        if (Ores.oreNumberStatic == 3) // Coal
        {
            if (PlayerStats.oreCoalAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * oreCoalValue;
                PlayerStats.oreCoalAmount -= amountToSell;
            }
        }
        if (Ores.oreNumberStatic == 4) // Tin
        {
            if (PlayerStats.oreTinAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * oreTinValue;
                PlayerStats.oreTinAmount -= amountToSell;
            }
        }
        if (Ores.oreNumberStatic == 5) // Copper
        {
            if (PlayerStats.oreCopperAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * oreCopperValue;
                PlayerStats.oreCopperAmount -= amountToSell;
            }
        }
        if (Ores.oreNumberStatic == 6) // Lead
        {
            if (PlayerStats.oreLeadAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * oreLeadValue;
                PlayerStats.oreLeadAmount -= amountToSell;
            }
        }
        if (Ores.oreNumberStatic == 7) // Silver
        {
            if (PlayerStats.oreSilverAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * oreSilverValue;
                PlayerStats.oreSilverAmount -= amountToSell;
            }
        }
        if (Ores.oreNumberStatic == 8) // Zinc
        {
            if (PlayerStats.oreZincAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * oreZincValue;
                PlayerStats.oreZincAmount -= amountToSell;
            }
        }
        if (Ores.oreNumberStatic == 9) // Gold
        {
            if (PlayerStats.oreGoldAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * oreGoldValue;
                PlayerStats.oreGoldAmount -= amountToSell;
            }
        }
        if (Ores.oreNumberStatic == 10) // Titanium
        {
            if (PlayerStats.oreTitaniumAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * oreTitaniumValue;
                PlayerStats.oreTitaniumAmount -= amountToSell;
            }
        }
        if (Ores.oreNumberStatic == 11) // Uranium
        {
            if (PlayerStats.oreUraniumAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * oreUraniumValue;
                PlayerStats.oreUraniumAmount -= amountToSell;
            }
        }

        if (Logs.logNumberStatic == 1) // Pine
        {
            if (PlayerStatsForestry.logPineAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * logPineValue;
                PlayerStatsForestry.logPineAmount -= amountToSell;
            }
        }

        if (Logs.logNumberStatic == 2) // Oak
        {
            if (PlayerStatsForestry.logOakAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * logOakValue;
                PlayerStatsForestry.logOakAmount -= amountToSell;
            }
        }

        if (Logs.logNumberStatic == 3) // Spruce
        {
            if (PlayerStatsForestry.logSpruceAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * logSpruceValue;
                PlayerStatsForestry.logSpruceAmount -= amountToSell;
            }
        }

        if (Logs.logNumberStatic == 4) // Willow
        {
            if (PlayerStatsForestry.logWillowAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * logWillowValue;
                PlayerStatsForestry.logWillowAmount -= amountToSell;
            }
        }

        if (Logs.logNumberStatic == 5) // Fir
        {
            if (PlayerStatsForestry.logFirAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * logFirValue;
                PlayerStatsForestry.logFirAmount -= amountToSell;
            }
        }

        if (Logs.logNumberStatic == 6) // Cherry
        {
            if (PlayerStatsForestry.logCherryAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * logCherryValue;
                PlayerStatsForestry.logCherryAmount -= amountToSell;
            }
        }

        if (Logs.logNumberStatic == 7) // Mahogany
        {
            if (PlayerStatsForestry.logMahoganyAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * logMahoganyValue;
                PlayerStatsForestry.logMahoganyAmount -= amountToSell;
            }
        }

        if (Logs.logNumberStatic == 8) // Elder
        {
            if (PlayerStatsForestry.logElderAmount >= amountToSell && amountToSell > 0)
            {
                PlayerStats.totalEuroAmount += amountToSell * logElderValue;
                PlayerStatsForestry.logElderAmount -= amountToSell;
            }
        }
    }
}

