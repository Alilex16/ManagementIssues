using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RouteToWork : MonoBehaviour, IPointerClickHandler {

    //public int routeNumber;
    [Header("Amount of Workers per Route")]
    public static int workersRoute01;
    public static int workersRoute02;
    public static int workersRoute03;
    public static int workersRoute04;
    public static int workersRoute05;
    public static int workersRoute06;


    private string routeString;

    [Header("Stats per Employee")]
    public int shareSpeed; //worked while not being static
    public int shareStrength;
    
    public GameObject hiredContent;
    
    public static GameObject employeeChosen;
    
    //these used to be private
    private string tempInt;
    private GameObject onlyThisEmployee;
    private Text thisText;

    

    public static RouteToWork instance;

    void Awake()
    {
        instance = this;
    }
    

    public void OldRouteE01() //UNUSED??
    {
        //Debug.Log("E01Old Route: " + routeChosenE01);
        //routeString = "Route: None";
        //routeTextE01.text = routeString; //changes the route on the info board

        //shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        //shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;

    }

    public void OldRoute() //run this when changing routes or firing
    {
        //int tempInt; //instead of storing it here, store the Old and Current Route in EmployeeExtra

        //int.TryParse(EmployeeExtra.displayRoute.ToString(), out tempInt);

        //Debug.Log("Second: " + thisText.text.ToString());


        //Debug.Log("Before: " + thisText.text.ToString());
        
        //
        //tempInt = EmployeeExtra.employeeNumberStatic.ToString();

        //onlyThisEmployee = GameObject.Find(tempInt);

        //thisText = onlyThisEmployee.GetComponentInChildren<Text>();
        //

        //DecidedStuff();

        //Debug.Log("After: " + thisText.text.ToString());

        shareSpeed = EmployeeExtra.speedStatic;
        shareStrength = EmployeeExtra.strengthStatic;

        if (EmployeeHiring.employeeRouteStaticText == "")
        {
            //Debug.Log("No Roads Taken");
        }

        if (EmployeeHiring.employeeRouteStaticText == "Basic Minerals")
        {
            Route01RemoveIncome();
            //Debug.Log("This works too. Old route: 1");
        }

        if (EmployeeHiring.employeeRouteStaticText == "Interesting Mix")
        {
            Route02RemoveIncome();
            //Debug.Log("Old route: 2");
        }

        if (EmployeeHiring.employeeRouteStaticText == "Long Haul")
        {
            Route03RemoveIncome();
            //Debug.Log("Old route: 3");
        }

        if (EmployeeHiring.employeeRouteStaticText == "Dangerous Extraction")
        {
            Route04RemoveIncome();
            //Debug.Log("Old route: 4");
        }
        if (EmployeeHiring.employeeRouteStaticText == "Heavy Metal")
        {
            Route05RemoveIncome();
            //Debug.Log("Old route: 5");
        }
        if (EmployeeHiring.employeeRouteStaticText == "Shiny")
        {
            Route06RemoveIncome();
            //Debug.Log("Old route: 6");
        }

        
        //OBJECT FINDING ISSUES
        
        //tempObject = hiredContent.transform.Find(thisInt).gameObject;
        
        //thisInt = EmployeeFired.employeeStatic.ToString();
        
        //tempObject = GameObject.Find(thisInt); // This works, but returns nothing
        
        //if (tempText != null)
        //{
        //    tempText = tempObject.GetComponentInChildren<Text>();

        //    tempText.text = "";
        //}
    
        //thisText.text = routeString;
        //EmployeeHiring.employeeRouteStaticText = ""; //EmployeeExtra.displayRoute = thisText.text; -> doesn't work
        
        //tempText = tempObject.GetComponentInChildren<Text>();

        
        //tempText = tempObject.GetComponentInChildren<Text>(); //use the text in its child

        //tempText.text = "this";
        
        //EmployeeHiring.employeeRouteStaticText = "";
        
        //tempInt = EmployeeExtra.employeeNumberStatic.ToString(); //get the employee ID number

        //onlyThisEmployee = GameObject.Find(tempInt); //find the corresponding gameObject

        //Debug.Log(tempInt);

        //thisText = onlyThisEmployee.GetComponentInChildren<Text>(); //use the text in its child

        //thisText.text = "";

        //EmployeeHiring.employeeRouteStaticText = "None";
    }
    
    

    public static bool isUsed;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isUsed == false)
        {
            isUsed = true;
        }
        
        int rc = RouteChoose.routeNumberStatic;
        
        //a = GameObject.Find("Employees").GetComponents<Employees.speed>();

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;
        

        //if (EmployeeExtra.employeeNumberStatic == 1)
        //{
        //if (has iron pickaxe)
        //{
        //IronMiningAllowed = true
        //}

        //OldRouteE01(); // before or after pickaxe check?
        //}
        

        tempInt = EmployeeExtra.employeeNumberStatic.ToString(); //get the employee ID number

        onlyThisEmployee = GameObject.Find(tempInt); //find the corresponding gameObject

        thisText = onlyThisEmployee.GetComponentInChildren<Text>(); //use the text in its child
        
        
        OldRoute();
        

        if (rc == 1)
        {

            //employeeChosen.transform.SetParent(route01.transform); //don't change the parent, just set the employee to a static int/string

            workersRoute01 += 1; //sent another worker on this route
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

        if (rc == 2)
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

        if (rc == 3)
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

        if (rc == 4)
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

        if (rc == 5)
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

        if (rc == 6)
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
        
        thisText.text = routeString;
        
        EmployeeHiring.employeeRouteStaticText = routeString; //EmployeeExtra.displayRoute = thisText.text; -> doesn't work

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

}
