using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseRouteForestry : MonoBehaviour {

    List<string> routeOptions = new List<string>() { "Gather Logs", "Meadow", "Grove", "Ominous Woods", "Ancient Forest", "Mystic Grove" };

    public Dropdown dropdown;

    public GameObject goWorkButton; //button to allow employee to follow the route
    
    public Image route01;
    public Image route02;
    public Image route03;
    public Image route04;
    public Image route05;
    public Image route06;

    public Text route01Rewards;
    public Text route02Rewards;
    public Text route03Rewards;
    public Text route04Rewards;
    public Text route05Rewards;
    public Text route06Rewards;
    
    public static int routeNumberStatic;

    
    void Start ()
    {
        GetComponent<Dropdown>().captionText.text = "CHOOSE ROUTE";
        RouteOptionsList();
	}

    void RouteOptionsList()
    {
        dropdown.AddOptions(routeOptions);
    }
    
    public void Dropdown_IndexChanged (int options)
    {
        ResetMap();
        ResetInfo();
        goWorkButton.SetActive(true);

        routeNumberStatic = options;
        
        if (options == 0) //no route selected
        {
            goWorkButton.SetActive(false);
            //routeNumberStatic = 0;
            Debug.Log("You need to select a valid route");
        }
        if (options == 1)
        {
            route01.enabled = true;
            route01Rewards.enabled = true;
            //routeNumberStatic = 1;
        }
        if (options == 2)
        {
            route02.enabled = true;
            route02Rewards.enabled = true;
        }
        if (options == 3)
        {
            route03.enabled = true;
            route03Rewards.enabled = true;
        }
        if (options == 4)
        {
            route04.enabled = true;
            route04Rewards.enabled = true;
        }
        if (options == 5)
        {
            route05.enabled = true;
            route05Rewards.enabled = true;
        }
        if (options == 6)
        {
            route06.enabled = true;
            route06Rewards.enabled = true;
        }
    }
    
    public void ResetMap()
    {
        route01.enabled = false;
        route02.enabled = false;
        route03.enabled = false;
        route04.enabled = false;
        route05.enabled = false;
        route06.enabled = false;
    }

    public void ResetInfo()
    {
        route01Rewards.enabled = false;
        route02Rewards.enabled = false;
        route03Rewards.enabled = false;
        route04Rewards.enabled = false;
        route05Rewards.enabled = false;
        route06Rewards.enabled = false;
    }
    
}
