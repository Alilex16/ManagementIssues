using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Smelting : MonoBehaviour, IDropHandler
{

    //private bool startedSmelting; //instead of bool, check if parent(smelter01) has a child
    // OLD TEXT : define which ore should start smelting, instead of a bool (Ores.oreNumberStatic)
    
    private int beingSmelted;

    public GameObject toggleButton;
    public Image smeltingBarImage;

    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            if (Ores.itemBeingDragged != null) // this means, it only works if item is an Ore (aka not a log)
            {
                if (Ores.oreNumberStatic == 3 || Ores.oreNumberStatic == 11)
                {
                    //warning that you cannot smelt coal or uranium
                }
                else
                {
                    StartSmelting();
                }
            }
        }
        else
        {
            if (Ores.itemBeingDragged != null)
            {
                if (Ores.oreNumberStatic == 3 || Ores.oreNumberStatic == 11)
                {
                    //warning that you cannot smelt coal or uranium
                }
                else
                {
                    Destroy(transform.GetChild(0).gameObject);
                    CancelInvoke(); //resets the smithing progress
                    ResetSmeltingBar(); //resets the bar, visualizing the reset of the smithing process

                    StartSmelting();
                }
            }
        }
    }

    void StartSmelting()
    {
        beingSmelted = Ores.oreNumberStatic;

        GameObject copy = (GameObject)Instantiate(Ores.itemBeingDragged); // I know (GameObject) is redundant. IDC. :-)
        copy.transform.SetParent(transform, false);

        Destroy(copy.transform.GetChild(0).gameObject); //remove the text (amount of ores)

        RectTransform rect = copy.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(100, 100); // fixes the size x/y
        
        copy.transform.localRotation = Quaternion.identity;
        copy.transform.localScale = Vector3.one;
        copy.transform.localPosition = new Vector3(0, 0, 0);
        
        DecideOre();
    }


    [Header("Ore Smelting Speed")]
    public static float rockSmeltSpeed;
    public static float ironSmeltSpeed;
    public static float tinSmeltSpeed;
    public static float copperSmeltSpeed;
    public static float leadSmeltSpeed;
    public static float silverSmeltSpeed;
    public static float zincSmeltSpeed;
    public static float goldSmeltSpeed;
    public static float titaniumSmeltSpeed;
    private float smeltingSpeed;


    public void DecideOre() //Update -> DecideOre. Add function call at the bottom of StartSmelting()
    {
        //beingSmelted = Ores.oreNumberStatic;

        if (transform.childCount > 0)
        {
            if (GetComponentInChildren<Ores>())
            {
                //add the toggle here. Link it to the button.
                if (toggleButton.GetComponent<Toggle>().isOn == true) //(smeltingAllowed == true) //not bool. check if button isOn
                {


                    if (beingSmelted == 1) //if Rocks
                    {
                        //Debug.Log("Iron being smelted");

                        rockSmeltSpeed = PlayerStats.hardnessRock * 5; //change this to an avarage of all hardnesses, then randomize the outcome (+/- 50%)

                        if (PlayerStats.oreRocksAmount > 5) //if has enough iron in inventory //only first check
                        {
                            smeltingSpeed = rockSmeltSpeed;
                            
                            //InvokeRepeating("SmeltIron", 1f, 1f); //smelting speed for iron (make this variable??)

                            Invoke("SmeltRocks", rockSmeltSpeed); //
                            //InvokeRepeating("SmelterBarImage", 0f, 1f);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }

                    if (beingSmelted == 2) //if Iron
                    {
                        //Debug.Log("Iron being smelted");

                        ironSmeltSpeed = PlayerStats.hardnessIron + (PlayerStats.hardnessIron * PlayerStats.hardnessIron); //PlayerStats.Hardness //smelting experience // skills

                        if (PlayerStats.oreIronAmount > 5) //if has enough iron in inventory //only first check
                        {
                            smeltingSpeed = ironSmeltSpeed;
                            //InvokeRepeating("SmeltIron", 1f, 1f); //smelting speed for iron (make this variable??)
                            Invoke("SmeltIron", ironSmeltSpeed); //
                            //InvokeRepeating("SmelterBarImage", 1f, 1f);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }










                    if (beingSmelted == 4) //if Tin
                    {
                        tinSmeltSpeed = PlayerStats.hardnessTin + (PlayerStats.hardnessTin * PlayerStats.hardnessTin);

                        if (PlayerStats.oreTinAmount > 5)
                        {
                            smeltingSpeed = tinSmeltSpeed;
                            Invoke("SmeltTin", tinSmeltSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }

                    if (beingSmelted == 5) //if Copper
                    {
                        copperSmeltSpeed = PlayerStats.hardnessCopper + (PlayerStats.hardnessCopper * PlayerStats.hardnessCopper);

                        if (PlayerStats.oreCopperAmount > 5)
                        {
                            smeltingSpeed = copperSmeltSpeed;
                            Invoke("SmeltCopper", copperSmeltSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }

                    if (beingSmelted == 6) //if Lead
                    {
                        leadSmeltSpeed = PlayerStats.hardnessLead + (PlayerStats.hardnessLead * PlayerStats.hardnessLead);

                        if (PlayerStats.oreLeadAmount > 5)
                        {
                            smeltingSpeed = leadSmeltSpeed;
                            Invoke("SmeltLead", leadSmeltSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }

                    if (beingSmelted == 7) //if Silver
                    {
                        silverSmeltSpeed = PlayerStats.hardnessSilver + (PlayerStats.hardnessSilver * PlayerStats.hardnessSilver);

                        if (PlayerStats.oreSilverAmount > 5)
                        {
                            smeltingSpeed = silverSmeltSpeed;
                            Invoke("SmeltSilver", silverSmeltSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }

                    if (beingSmelted == 8) //if Zinc
                    {
                        zincSmeltSpeed = PlayerStats.hardnessZinc + (PlayerStats.hardnessZinc * PlayerStats.hardnessZinc);

                        if (PlayerStats.oreZincAmount > 5)
                        {
                            smeltingSpeed = zincSmeltSpeed;
                            Invoke("SmeltZinc", zincSmeltSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }

                    if (beingSmelted == 9) //if Gold
                    {
                        goldSmeltSpeed = PlayerStats.hardnessGold + (PlayerStats.hardnessGold * PlayerStats.hardnessGold);

                        if (PlayerStats.oreGoldAmount > 5)
                        {
                            smeltingSpeed = goldSmeltSpeed;
                            Invoke("SmeltGold", goldSmeltSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }

                    if (beingSmelted == 10) //if Titanium
                    {
                        titaniumSmeltSpeed = PlayerStats.hardnessTitanium + (PlayerStats.hardnessTitanium * PlayerStats.hardnessTitanium);

                        if (PlayerStats.oreTitaniumAmount > 5)
                        {
                            smeltingSpeed = titaniumSmeltSpeed;
                            Invoke("SmeltTitanium", titaniumSmeltSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }

                }
                else //if button is toggeled, reset the smelting progress
                {
                    CancelInvoke();
                    ResetSmeltingBar();
                }
                
            }

        }

        //if have enough ITEM && Bool is ON, smelt ITEM every TIMEVALUE

        //add a toggle to start or stop smelting the ore

        //if child
        //if child contains "ore number X"
    }

    

    public void SmeltRocks()
    {
        PlayerStats.oreRocksAmount -= 25; //variable?
        
        int randomIngot = Random.Range(0, 100);

        if (randomIngot >= 0 && randomIngot <= 3)
        {
            PlayerStats.ingotIronAmount += 1; //4%
        }
        if (randomIngot >= 4 && randomIngot <= 21)
        {
            PlayerStats.ingotTinAmount += 1; //18%
        }
        if (randomIngot >= 22 && randomIngot <= 33)
        {
            PlayerStats.ingotCopperAmount += 1; //12%
        }
        if (randomIngot >= 34 && randomIngot <= 51)
        {
            PlayerStats.ingotLeadAmount += 1; //18%
        }
        if (randomIngot >= 52 && randomIngot <= 63)
        {
            PlayerStats.ingotSilverAmount += 1;  //12%
        }
        if (randomIngot >= 64 && randomIngot <= 71)
        {
            PlayerStats.ingotZincAmount += 1; //8%
        }
        if (randomIngot >= 72 && randomIngot <= 83)
        {
            PlayerStats.ingotGoldAmount += 1; //12%
        }
        if (randomIngot == 84)
        {
            PlayerStats.ingotTitaniumAmount += 1; //1%
        }
        if (randomIngot >= 85)
        {
            //you gain nothing. 15% chance;
        }

        if (PlayerStats.oreRocksAmount >= 25)
        {
            ResetSmeltingBar();
            DecideOre(); //if enough ore, keep smelting
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false; //if not enough ore, stop smelting
            //CancelInvoke("SmeltIron");
        }
        //Debug.Log("Iron ingots total: " + PlayerStats.ingotIronAmount);
    }

    public void SmeltIron()
    {
        PlayerStats.oreIronAmount -= 5; //variable?
        PlayerStats.ingotIronAmount += 1; //variable?

        if (PlayerStats.oreIronAmount >= 5)
        {
            ResetSmeltingBar(); 
            DecideOre(); //if enough ore, keep smelting
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false; //if not enough ore, stop smelting
            //CancelInvoke("SmeltIron");
        }
        //Debug.Log("Iron ingots total: " + PlayerStats.ingotIronAmount);
    }

    public void SmeltTin()
    {
        PlayerStats.oreTinAmount -= 5;
        PlayerStats.ingotTinAmount += 1;

        if (PlayerStats.oreTinAmount >= 5)
        {
            ResetSmeltingBar();
            DecideOre();
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false;
        }
    }

    public void SmeltCopper()
    {
        PlayerStats.oreCopperAmount -= 5;
        PlayerStats.ingotCopperAmount += 1;

        if (PlayerStats.oreCopperAmount >= 5)
        {
            ResetSmeltingBar();
            DecideOre();
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false;
        }
    }

    public void SmeltLead()
    {
        PlayerStats.oreLeadAmount -= 5;
        PlayerStats.ingotLeadAmount += 1;

        if (PlayerStats.oreLeadAmount >= 5)
        {
            ResetSmeltingBar();
            DecideOre();
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false;
        }
    }

    public void SmeltSilver()
    {
        PlayerStats.oreSilverAmount -= 5;
        PlayerStats.ingotSilverAmount += 1;

        if (PlayerStats.oreSilverAmount >= 5)
        {
            ResetSmeltingBar();
            DecideOre();
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false;
        }
    }

    public void SmeltZinc()
    {
        PlayerStats.oreZincAmount -= 5;
        PlayerStats.ingotZincAmount += 1;

        if (PlayerStats.oreZincAmount >= 5)
        {
            ResetSmeltingBar();
            DecideOre();
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false;
        }
    }

    public void SmeltGold()
    {
        PlayerStats.oreGoldAmount -= 5;
        PlayerStats.ingotGoldAmount += 1;

        if (PlayerStats.oreGoldAmount >= 5)
        {
            ResetSmeltingBar();
            DecideOre();
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false;
        }
    }

    public void SmeltTitanium()
    {
        PlayerStats.oreTitaniumAmount -= 5;
        PlayerStats.ingotTitaniumAmount += 1;

        if (PlayerStats.oreTitaniumAmount >= 5)
        {
            ResetSmeltingBar();
            DecideOre();
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false;
        }
    }


    private void ResetSmeltingBar()
    {
        elapsedFloat = 0;
        smeltingBarImage.fillAmount = 0f;
    }



    float elapsedFloat = 0;
    //int elapsedInt = 0;

    void Update()
    {
        if (toggleButton.GetComponent<Toggle>().isOn == true && transform.childCount > 0)
        {
            //if busy smelting
            elapsedFloat += Time.deltaTime;
            //elapsedInt = Mathf.RoundToInt(elapsedFloat);
            smeltingBarImage.fillAmount = elapsedFloat / smeltingSpeed; //visually not upgraded when switching screens. instead of disable, use the alpha?
        }
    }
}