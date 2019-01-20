using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class WoodTreatment : MonoBehaviour, IDropHandler
{
    private int beingTreated;

    public GameObject toggleButton;
    public Image processBarImage;

    private float treatmentSpeed;
    
    
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            if (Logs.itemBeingDragged != null)
            {
                StartTreatment();
            }
        }
        else
        {
            if (Logs.itemBeingDragged != null)
            {
                Destroy(transform.GetChild(0).gameObject);
                CancelInvoke(); //resets the treatment progress
                ResetProcessBar(); //resets the process bar, visualizing the reset of the treatment process
                
                StartTreatment();
            }
        }
    }


    void StartTreatment()
    {
        beingTreated = Logs.logNumberStatic;

        GameObject copy = Instantiate(Logs.itemBeingDragged);
        copy.transform.SetParent(transform, false);
        
        Destroy(copy.transform.GetChild(0).gameObject); //remove the text (amount of logs)

        RectTransform rect = copy.GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(100, 100); // fixes the size x/y

        copy.transform.localRotation = Quaternion.identity;
        copy.transform.localScale = Vector3.one;
        copy.transform.localPosition = new Vector3(0, 0, 0);
        
        toggleButton.GetComponent<Toggle>().interactable = true;

        DecideLog();
    }


    [Header("Log Treatment Speed")]
    public static float pineTreatmentSpeed;
    public static float oakTreatmentSpeed;
    public static float spruceTreatmentSpeed;
    public static float willowTreatmentSpeed;
    public static float firTreatmentSpeed;
    public static float cherryTreatmentSpeed;
    public static float mahoganyTreatmentSpeed;
    public static float elderTreatmentSpeed;

    [Header("Wood Density")]
    private float pineDensity = 5f;
    private float oakDensity = 15f;
    private float spruceDensity = 3f;
    private float willowDensity = 12f;
    private float firDensity = 1f;
    private float cherryDensity = 10f;
    private float mahoganyDensity = 8f;
    private float elderDensity = 20f;


    public void DecideLog()
    {
        if (transform.childCount > 0)
        {
            if (GetComponentInChildren<Logs>())
            {
                //add the toggle here. Link it to the button.
                if (toggleButton.GetComponent<Toggle>().isOn == true)
                {
                    if (beingTreated == 1) //if pine
                    {
                        pineTreatmentSpeed = pineDensity * 3; // randomize the outcome (+/- 10%)

                        if (PlayerStatsForestry.logPineAmount > 3)
                        {
                            treatmentSpeed = pineTreatmentSpeed;
                            Invoke("TreatPine", pineTreatmentSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }
                    if (beingTreated == 2) //if oak
                    {
                        oakTreatmentSpeed = oakDensity * 3; // randomize the outcome (+/- 10%)

                        if (PlayerStatsForestry.logOakAmount > 3)
                        {
                            treatmentSpeed = oakTreatmentSpeed;
                            Invoke("TreatOak", oakTreatmentSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }
                    if (beingTreated == 3) //if Spruce
                    {
                        spruceTreatmentSpeed = spruceDensity * 3; // randomize the outcome (+/- 10%)

                        if (PlayerStatsForestry.logSpruceAmount > 3)
                        {
                            treatmentSpeed = spruceTreatmentSpeed;
                            Invoke("TreatSpruce", spruceTreatmentSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }
                    if (beingTreated == 4) //if Willow
                    {
                        willowTreatmentSpeed = willowDensity * 3; // randomize the outcome (+/- 10%)

                        if (PlayerStatsForestry.logWillowAmount > 3)
                        {
                            treatmentSpeed = willowTreatmentSpeed;
                            Invoke("TreatWillow", willowTreatmentSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }
                    if (beingTreated == 5) //if Fir
                    {
                        firTreatmentSpeed = firDensity * 3; // randomize the outcome (+/- 10%)

                        if (PlayerStatsForestry.logFirAmount > 3)
                        {
                            treatmentSpeed = firTreatmentSpeed;
                            Invoke("TreatFir", firTreatmentSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }
                    if (beingTreated == 6) //if Cherry
                    {
                        cherryTreatmentSpeed = cherryDensity * 3; // randomize the outcome (+/- 10%)

                        if (PlayerStatsForestry.logCherryAmount > 3)
                        {
                            treatmentSpeed = cherryTreatmentSpeed;
                            Invoke("TreatCherry", cherryTreatmentSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }
                    if (beingTreated == 7) //if Mahogany
                    {
                        mahoganyTreatmentSpeed = mahoganyDensity * 3; // randomize the outcome (+/- 10%)

                        if (PlayerStatsForestry.logMahoganyAmount > 3)
                        {
                            treatmentSpeed = mahoganyTreatmentSpeed;
                            Invoke("TreatMahogany", mahoganyTreatmentSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }
                    if (beingTreated == 8) //if Elder
                    {
                        elderTreatmentSpeed = elderDensity * 3; // randomize the outcome (+/- 10%)

                        if (PlayerStatsForestry.logElderAmount > 3)
                        {
                            treatmentSpeed = elderTreatmentSpeed;
                            Invoke("TreatElder", elderTreatmentSpeed);
                        }
                        else
                        {
                            toggleButton.GetComponent<Toggle>().isOn = false;
                        }
                    }
                }
                else //if button is toggeled, reset the treatment progress
                {
                    CancelInvoke();
                    ResetProcessBar();
                }
            }
        }
    }


    public void TreatPine()
    {
        PlayerStatsForestry.logPineAmount -= 3; //variable?
        PlayerStatsForestry.treatedSoftwoodAmount += 1; //variable?

        if (PlayerStatsForestry.logPineAmount >= 3)
        {
            ResetProcessBar();
            DecideLog(); //if enough logs, keep treating
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false; //if not enough logs, stop treatment
        }
    }

    public void TreatOak()
    {
        PlayerStatsForestry.logOakAmount -= 3;
        PlayerStatsForestry.treatedHardwoodAmount += 1;

        if (PlayerStatsForestry.logOakAmount >= 3)
        {
            ResetProcessBar();
            DecideLog();
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false;
        }
    }

    public void TreatSpruce()
    {
        PlayerStatsForestry.logSpruceAmount -= 3;
        PlayerStatsForestry.treatedSoftwoodAmount += 1;

        if (PlayerStatsForestry.logSpruceAmount >= 3)
        {
            ResetProcessBar();
            DecideLog();
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false;
        }
    }

    public void TreatWillow() // Willow
    {
        PlayerStatsForestry.logWillowAmount -= 3;
        PlayerStatsForestry.treatedHardwoodAmount += 1;

        if (PlayerStatsForestry.logWillowAmount >= 3)
        {
            ResetProcessBar();
            DecideLog();
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false;
        }
    }

    public void TreatFir() // Fir
    {
        PlayerStatsForestry.logFirAmount -= 3;
        PlayerStatsForestry.treatedSoftwoodAmount += 1;

        if (PlayerStatsForestry.logFirAmount >= 3)
        {
            ResetProcessBar();
            DecideLog();
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false;
        }
    }

    public void TreatCherry() // Cherry
    {
        PlayerStatsForestry.logCherryAmount -= 3;
        PlayerStatsForestry.treatedHardwoodAmount += 1;

        if (PlayerStatsForestry.logCherryAmount >= 3)
        {
            ResetProcessBar();
            DecideLog();
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false;
        }
    }

    public void TreatMahogany() // Mahogany
    {
        PlayerStatsForestry.logMahoganyAmount -= 3;
        PlayerStatsForestry.treatedHardwoodAmount += 1;

        if (PlayerStatsForestry.logMahoganyAmount >= 3)
        {
            ResetProcessBar();
            DecideLog();
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false;
        }
    }

    public void TreatElder() // Elder
    {
        PlayerStatsForestry.logElderAmount -= 3;
        PlayerStatsForestry.treatedDensewoodAmount += 1;

        if (PlayerStatsForestry.logElderAmount >= 3)
        {
            ResetProcessBar();
            DecideLog();
        }
        else
        {
            toggleButton.GetComponent<Toggle>().isOn = false;
        }
    }

    

    float elapsedFloat = 0;

    private void ResetProcessBar()
    {
        elapsedFloat = 0;
        processBarImage.fillAmount = 0f;
    }


    void Update()
    {
        if (toggleButton.GetComponent<Toggle>().isOn == true && transform.childCount > 0)
        {
            elapsedFloat += Time.deltaTime;
            processBarImage.fillAmount = elapsedFloat / treatmentSpeed;

        }
    }

}
