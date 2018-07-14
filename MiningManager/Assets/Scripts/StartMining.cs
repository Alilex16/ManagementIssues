using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StartMining : MonoBehaviour, IPointerClickHandler { //CHANGE THIS TO "StartWorking" ?

    //public int routeNumber;
    [Header("Amount of Workers per Route")]
    public static int workersRoute01;
    public static int workersRoute02;
    public static int workersRoute03;
    public static int workersRoute04;
    public static int workersRoute05;
    public static int workersRoute06;
    public static int forestryRoute01;
    public static int forestryRoute02;
    public static int forestryRoute03;
    public static int forestryRoute04;
    public static int forestryRoute05;
    public static int forestryRoute06;
    
    public GameObject miningMenu;
    public GameObject forestryMenu;
    
    private string routeString;

    [Header("Stats per Employee")]
    public int shareSpeed; //worked while not being static
    public int shareStrength;
    
    public GameObject hiredContent;
    
    public static GameObject employeeChosen;
    
    private string tempInt;
    private GameObject onlyThisEmployee;
    private Text thisText;
    

    public static StartMining instance;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        GetComponent<PlayerStatsForestry>();
    }
    
    public void OldRoute() //run this when changing routes or firing
    {
        //int tempInt; //instead of storing it here, store the Old and Current Route in EmployeeExtra
        
        shareSpeed = EmployeeExtra.speedStatic;
        shareStrength = EmployeeExtra.strengthStatic;

        if (EmployeeHiring.employeeRouteStaticText == "")
        {
            //Debug.Log("No Roads Taken");
        }
        if (EmployeeHiring.employeeRouteStaticText == "Basic Minerals")
        {
            Route01RemoveIncome();
        }
        if (EmployeeHiring.employeeRouteStaticText == "Interesting Mix")
        {
            Route02RemoveIncome();
        }
        if (EmployeeHiring.employeeRouteStaticText == "Long Haul")
        {
            Route03RemoveIncome();
        }
        if (EmployeeHiring.employeeRouteStaticText == "Dangerous Extraction")
        {
            Route04RemoveIncome();
        }
        if (EmployeeHiring.employeeRouteStaticText == "Heavy Metal")
        {
            Route05RemoveIncome();
        }
        if (EmployeeHiring.employeeRouteStaticText == "Shiny")
        {
            Route06RemoveIncome();
        }



        if (EmployeeHiring.employeeRouteStaticText == "Gather Logs")
        {
            Route01RemoveIncomeForestry();
        }
        if (EmployeeHiring.employeeRouteStaticText == "Meadow")
        {
            Route02RemoveIncomeForestry();
        }
        if (EmployeeHiring.employeeRouteStaticText == "Grove")
        {
            Route03RemoveIncomeForestry();
        }
        if (EmployeeHiring.employeeRouteStaticText == "Ominous Woods")
        {
            Route04RemoveIncomeForestry();
        }
        if (EmployeeHiring.employeeRouteStaticText == "Ancient Forest")
        {
            Route05RemoveIncomeForestry();
        }
        if (EmployeeHiring.employeeRouteStaticText == "Mystic Grove")
        {
            Route06RemoveIncomeForestry();
        }
    }
    
    
    public static bool isUsed;
    private int routeChosen;


    public void OnPointerClick(PointerEventData eventData)
    {
        if (isUsed == false)
        {
            isUsed = true;
        }
        

        if (miningMenu.activeInHierarchy)
        {
            Debug.Log("A miner has been sent out.");
            routeChosen = ChooseRouteMining.routeNumberStatic;
        }

        if (forestryMenu.activeInHierarchy)
        {
            Debug.Log("Someone is now getting wood.");
            routeChosen = ChooseRouteForestry.routeNumberStatic;
        }
        

        
        //a = GameObject.Find("Employees").GetComponents<Employees.speed>();

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;
        

        //if (EmployeeExtra.employeeNumberStatic == 1)
        //{
        //if (has iron pickaxe)
        //{
        //IronMiningAllowed = true
        //}

        

        tempInt = EmployeeExtra.employeeNumberStatic.ToString(); //get the employee ID number

        onlyThisEmployee = GameObject.Find(tempInt); //find the corresponding gameObject

        thisText = onlyThisEmployee.GetComponentInChildren<Text>(); //use the text in its child
        
        
        OldRoute(); // before or after pickaxe check?

        GainIncome();
        
        thisText.text = routeString;
        
        EmployeeHiring.employeeRouteStaticText = routeString; //EmployeeExtra.displayRoute = thisText.text; -> doesn't work
    }

    
    private void GainIncome()
    {
        if (routeChosen == 1 && miningMenu.activeInHierarchy)
        {

            //employeeChosen.transform.SetParent(route01.transform); //don't change the parent, just set the employee to a static int/string

            workersRoute01 += 1; // sent another worker on this route
            routeString = "Basic Minerals";

            //gain rocks, iron, coal, tin and copper
            PlayerStats.gatheringSpeedRocks += shareSpeed;
            PlayerStats.gatheringStrengthRocks += shareStrength;
            PlayerStats.gatheringSpeedIron += shareSpeed;
            PlayerStats.gatheringStrengthIron += shareStrength;
            PlayerStats.gatheringSpeedCoal += shareSpeed;
            PlayerStats.gatheringStrengthCoal += shareStrength;
            PlayerStats.gatheringSpeedTin += shareSpeed;
            PlayerStats.gatheringStrengthTin += shareStrength;
            PlayerStats.gatheringSpeedCopper += shareSpeed;
            PlayerStats.gatheringStrengthCopper += shareStrength;
        }

        if (routeChosen == 2 && miningMenu.activeInHierarchy)
        {
            workersRoute02 += 1;
            routeString = "Interesting Mix";

            //gain rocks, iron, silver, zinc
            PlayerStats.gatheringSpeedRocks += shareSpeed;
            PlayerStats.gatheringStrengthRocks += shareStrength;
            PlayerStats.gatheringSpeedIron += shareSpeed;
            PlayerStats.gatheringStrengthIron += shareStrength;
            PlayerStats.gatheringSpeedSilver += shareSpeed;
            PlayerStats.gatheringStrengthSilver += shareStrength;
            PlayerStats.gatheringSpeedZinc += shareSpeed;
            PlayerStats.gatheringStrengthZinc += shareStrength;
        }

        if (routeChosen == 3 && miningMenu.activeInHierarchy)
        {
            workersRoute03 += 1;
            routeString = "Long Haul";

            //gain rocks, iron, lead, gold, titanium
            PlayerStats.gatheringSpeedRocks += shareSpeed;
            PlayerStats.gatheringStrengthRocks += shareStrength;
            PlayerStats.gatheringSpeedIron += shareSpeed;
            PlayerStats.gatheringStrengthIron += shareStrength;
            PlayerStats.gatheringSpeedLead += shareSpeed;
            PlayerStats.gatheringStrengthLead += shareStrength;
            PlayerStats.gatheringSpeedGold += shareSpeed;
            PlayerStats.gatheringStrengthGold += shareStrength;
            PlayerStats.gatheringSpeedTitanium += shareSpeed;
            PlayerStats.gatheringStrengthTitanium += shareStrength;
        }

        if (routeChosen == 4 && miningMenu.activeInHierarchy)
        {
            workersRoute04 += 1;
            routeString = "Dangerous Extraction";

            //gain rocks, coal, lead, uranium
            PlayerStats.gatheringSpeedRocks += shareSpeed;
            PlayerStats.gatheringStrengthRocks += shareStrength;
            PlayerStats.gatheringSpeedCoal += shareSpeed;
            PlayerStats.gatheringStrengthCoal += shareStrength;
            PlayerStats.gatheringSpeedLead += shareSpeed;
            PlayerStats.gatheringStrengthLead += shareStrength;
            PlayerStats.gatheringSpeedUranium += shareSpeed;
            PlayerStats.gatheringStrengthUranium += shareStrength;
        }

        if (routeChosen == 5 && miningMenu.activeInHierarchy)
        {
            workersRoute05 += 1;
            routeString = "Heavy Metal";

            //gain rocks, copper, zinc, titanium
            PlayerStats.gatheringSpeedRocks += shareSpeed;
            PlayerStats.gatheringStrengthRocks += shareStrength;
            PlayerStats.gatheringSpeedCopper += shareSpeed;
            PlayerStats.gatheringStrengthCopper += shareStrength;
            PlayerStats.gatheringSpeedZinc += shareSpeed;
            PlayerStats.gatheringStrengthZinc += shareStrength;
            PlayerStats.gatheringSpeedTitanium += shareSpeed;
            PlayerStats.gatheringStrengthTitanium += shareStrength;
        }

        if (routeChosen == 6 && miningMenu.activeInHierarchy)
        {
            workersRoute06 += 1;
            routeString = "Shiny";

            //gain rocks, silver, gold
            PlayerStats.gatheringSpeedRocks += shareSpeed;
            PlayerStats.gatheringStrengthRocks += shareStrength;
            PlayerStats.gatheringSpeedSilver += shareSpeed;
            PlayerStats.gatheringStrengthSilver += shareStrength;
            PlayerStats.gatheringSpeedGold += shareSpeed;
            PlayerStats.gatheringStrengthGold += shareStrength;
        }


        if (routeChosen == 1 && forestryMenu.activeInHierarchy)
        {
            forestryRoute01 += 1;
            routeString = "Gather Logs";

            //gain all logs, the better, the rarer
            //Speed and strength are irrelevant here
        }

        if (routeChosen == 2 && forestryMenu.activeInHierarchy)
        {
            forestryRoute02 += 1;
            routeString = "Meadow";

            PlayerStatsForestry.route02Speed += shareSpeed;
            PlayerStatsForestry.instance.Route02Strength += shareStrength;
        }

        if (routeChosen == 3 && forestryMenu.activeInHierarchy)
        {
            forestryRoute03 += 1;
            routeString = "Grove";

            PlayerStatsForestry.route03Speed += shareSpeed;
            PlayerStatsForestry.route03Strength += shareStrength;
        }

        if (routeChosen == 4 && forestryMenu.activeInHierarchy)
        {
            forestryRoute04 += 1;
            routeString = "Ominous Woods";

            PlayerStatsForestry.route04Speed += shareSpeed;
            PlayerStatsForestry.route04Strength += shareStrength;
        }

        if (routeChosen == 5 && forestryMenu.activeInHierarchy)
        {
            forestryRoute05 += 1;
            routeString = "Ancient Forest";

            PlayerStatsForestry.route05Speed += shareSpeed;
            PlayerStatsForestry.route05Strength += shareStrength;
        }

        if (routeChosen == 6 && forestryMenu.activeInHierarchy)
        {
            forestryRoute06 += 1;
            routeString = "Mystic Grove";

            PlayerStatsForestry.route06Speed += shareSpeed;
            PlayerStatsForestry.route06Strength += shareStrength;
        }
    }

    private void Route01RemoveIncome()
    {
        workersRoute01 -= 1;
        PlayerStats.gatheringSpeedRocks -= shareSpeed;
        PlayerStats.gatheringStrengthRocks -= shareStrength;
        PlayerStats.gatheringSpeedIron -= shareSpeed;
        PlayerStats.gatheringStrengthIron -= shareStrength;
        PlayerStats.gatheringSpeedCoal -= shareSpeed;
        PlayerStats.gatheringStrengthCoal -= shareStrength;
        PlayerStats.gatheringSpeedTin -= shareSpeed;
        PlayerStats.gatheringStrengthTin -= shareStrength;
        PlayerStats.gatheringSpeedCopper -= shareSpeed;
        PlayerStats.gatheringStrengthCopper -= shareStrength;
    }

    private void Route02RemoveIncome()
    {
        workersRoute02 -= 1;
        PlayerStats.gatheringSpeedRocks -= shareSpeed;
        PlayerStats.gatheringStrengthRocks -= shareStrength;
        PlayerStats.gatheringSpeedIron -= shareSpeed;
        PlayerStats.gatheringStrengthIron -= shareStrength;
        PlayerStats.gatheringSpeedSilver -= shareSpeed;
        PlayerStats.gatheringStrengthSilver -= shareStrength;
        PlayerStats.gatheringSpeedZinc -= shareSpeed;
        PlayerStats.gatheringStrengthZinc -= shareStrength;
    }

    private void Route03RemoveIncome()
    {
        workersRoute03 -= 1;
        PlayerStats.gatheringSpeedRocks -= shareSpeed;
        PlayerStats.gatheringStrengthRocks -= shareStrength;
        PlayerStats.gatheringSpeedIron -= shareSpeed;
        PlayerStats.gatheringStrengthIron -= shareStrength;
        PlayerStats.gatheringSpeedLead -= shareSpeed;
        PlayerStats.gatheringStrengthLead -= shareStrength;
        PlayerStats.gatheringSpeedGold -= shareSpeed;
        PlayerStats.gatheringStrengthGold -= shareStrength;
        PlayerStats.gatheringSpeedTitanium -= shareSpeed;
        PlayerStats.gatheringStrengthTitanium -= shareStrength;
    }

    private void Route04RemoveIncome()
    {
        workersRoute04 -= 1;
        PlayerStats.gatheringSpeedRocks -= shareSpeed;
        PlayerStats.gatheringStrengthRocks -= shareStrength;
        PlayerStats.gatheringSpeedCoal -= shareSpeed;
        PlayerStats.gatheringStrengthCoal -= shareStrength;
        PlayerStats.gatheringSpeedLead -= shareSpeed;
        PlayerStats.gatheringStrengthLead -= shareStrength;
        PlayerStats.gatheringSpeedUranium -= shareSpeed;
        PlayerStats.gatheringStrengthUranium -= shareStrength;
    }

    private void Route05RemoveIncome()
    {
        workersRoute05 -= 1;
        PlayerStats.gatheringSpeedRocks -= shareSpeed;
        PlayerStats.gatheringStrengthRocks -= shareStrength;
        PlayerStats.gatheringSpeedCopper -= shareSpeed;
        PlayerStats.gatheringStrengthCopper -= shareStrength;
        PlayerStats.gatheringSpeedZinc -= shareSpeed;
        PlayerStats.gatheringStrengthZinc -= shareStrength;
        PlayerStats.gatheringSpeedTitanium -= shareSpeed;
        PlayerStats.gatheringStrengthTitanium -= shareStrength;
    }

    private void Route06RemoveIncome()
    {
        workersRoute06 -= 1;
        PlayerStats.gatheringSpeedRocks -= shareSpeed;
        PlayerStats.gatheringStrengthRocks -= shareStrength;
        PlayerStats.gatheringSpeedSilver -= shareSpeed;
        PlayerStats.gatheringStrengthSilver -= shareStrength;
        PlayerStats.gatheringSpeedGold -= shareSpeed;
        PlayerStats.gatheringStrengthGold -= shareStrength;
    }

    private void Route01RemoveIncomeForestry()
    {
        forestryRoute01 -= 1;
    }

    private void Route02RemoveIncomeForestry()
    {
        forestryRoute02 -= 1;
        PlayerStatsForestry.route02Speed -= shareSpeed;
        PlayerStatsForestry.instance.Route02Strength -= shareStrength;
    }

    private void Route03RemoveIncomeForestry()
    {
        forestryRoute03 -= 1;
        PlayerStatsForestry.route03Speed -= shareSpeed;
        PlayerStatsForestry.route03Strength -= shareStrength;
    }

    private void Route04RemoveIncomeForestry()
    {
        forestryRoute04 -= 1;
        PlayerStatsForestry.route04Speed -= shareSpeed;
        PlayerStatsForestry.route04Strength -= shareStrength;
    }

    private void Route05RemoveIncomeForestry()
    {
        forestryRoute05 -= 1;
        PlayerStatsForestry.route05Speed -= shareSpeed;
        PlayerStatsForestry.route05Strength -= shareStrength;
    }

    private void Route06RemoveIncomeForestry()
    {
        forestryRoute06 -= 1;
        PlayerStatsForestry.route06Speed -= shareSpeed;
        PlayerStatsForestry.route06Strength -= shareStrength;
    }
}
