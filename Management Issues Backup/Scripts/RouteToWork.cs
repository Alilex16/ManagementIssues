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

    [Header("Route Text per Employee")]
    public Text routeTextE01;
    public Text routeTextE02;
    public Text routeTextE03;
    public Text routeTextE04;
    public Text routeTextE05;
    public Text routeTextE06;
    public Text routeTextE07;
    public Text routeTextE08;
    public Text routeTextE09;
    public Text routeTextE10;
    public Text routeTextE11;
    public Text routeTextE12;
    public Text routeTextE13;
    public Text routeTextE14;


    //public int localSpeed;
    //public int localStrength;
    public int shareSpeed; //worked while not being static
    public int shareStrength;

    [Header("Route Chosen stored per Employee")]
    private int routeChosenE01 = 0;
    private int routeChosenE02;
    private int routeChosenE03;
    private int routeChosenE04;
    private int routeChosenE05;
    private int routeChosenE06;
    private int routeChosenE07;
    private int routeChosenE08 = 0;
    private int routeChosenE09;
    private int routeChosenE10;
    private int routeChosenE11;
    private int routeChosenE12;
    private int routeChosenE13;
    private int routeChosenE14;



    public static RouteToWork instance;

    void Awake()
    {
        instance = this;
    }



    public void OldRouteE01()
    {
        //Debug.Log("E01Old Route: " + routeChosenE01);
        routeString = "Route: None";
        routeTextE01.text = routeString; //changes the route on the info board

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;


        if (routeChosenE01 == 1)
        {
            Route01RemoveIncome();
            //Remove the income for route 1
            //Debug.Log("E01Old Route: " + routeChosenE01);
        }
        if (routeChosenE01 == 2)
        {
            Route02RemoveIncome();
        }
        if (routeChosenE01 == 3)
        {
            Route03RemoveIncome();
        }
        if (routeChosenE01 == 4)
        {
            Route04RemoveIncome();
        }
        if (routeChosenE01 == 5)
        {
            Route05RemoveIncome();
        }
        if (routeChosenE01 == 6)
        {
            Route06RemoveIncome();
        }

        routeChosenE01 = 0;
    }

    public void OldRouteE02()
    {
        //Debug.Log("E02Old Route: " + routeChosenE02);
        routeString = "Route: None";
        routeTextE02.text = routeString;

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;


        if (routeChosenE02 == 1)
        {
            Route01RemoveIncome();
        }
        if (routeChosenE02 == 2)
        {
            Route02RemoveIncome();
        }
        if (routeChosenE02 == 3)
        {
            Route03RemoveIncome();
        }
        if (routeChosenE02 == 4)
        {
            Route04RemoveIncome();
        }
        if (routeChosenE02 == 5)
        {
            Route05RemoveIncome();
        }
        if (routeChosenE02 == 6)
        {
            Route06RemoveIncome();
        }

        routeChosenE02 = 0;
    }


    public void OldRouteE03()
    {
        //Debug.Log("E02Old Route: " + routeChosenE02);
        routeString = "Route: None";
        routeTextE03.text = routeString;

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;


        if (routeChosenE03 == 1)
        {
            Route01RemoveIncome();
        }
        if (routeChosenE03 == 2)
        {
            Route02RemoveIncome();
        }
        if (routeChosenE03 == 3)
        {
            Route03RemoveIncome();
        }
        if (routeChosenE03 == 4)
        {
            Route04RemoveIncome();
        }
        if (routeChosenE03 == 5)
        {
            Route05RemoveIncome();
        }
        if (routeChosenE03 == 6)
        {
            Route06RemoveIncome();
        }

        routeChosenE03 = 0;
    }


    public void OldRouteE04()
    {
        //Debug.Log("E02Old Route: " + routeChosenE02);
        routeString = "Route: None";
        routeTextE04.text = routeString;

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;


        if (routeChosenE04 == 1)
        {
            Route01RemoveIncome();
        }
        if (routeChosenE04 == 2)
        {
            Route02RemoveIncome();
        }
        if (routeChosenE04 == 3)
        {
            Route03RemoveIncome();
        }
        if (routeChosenE04 == 4)
        {
            Route04RemoveIncome();
        }
        if (routeChosenE04 == 5)
        {
            Route05RemoveIncome();
        }
        if (routeChosenE04 == 6)
        {
            Route06RemoveIncome();
        }

        routeChosenE04 = 0;
    }


    public void OldRouteE05()
    {
        //Debug.Log("E02Old Route: " + routeChosenE02);
        routeString = "Route: None";
        routeTextE05.text = routeString;

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;


        if (routeChosenE05 == 1)
        {
            Route01RemoveIncome();
        }
        if (routeChosenE05 == 2)
        {
            Route02RemoveIncome();
        }
        if (routeChosenE05 == 3)
        {
            Route03RemoveIncome();
        }
        if (routeChosenE05 == 4)
        {
            Route04RemoveIncome();
        }
        if (routeChosenE05 == 5)
        {
            Route05RemoveIncome();
        }
        if (routeChosenE05 == 6)
        {
            Route06RemoveIncome();
        }

        routeChosenE05 = 0;
    }


    public void OldRouteE06()
    {
        //Debug.Log("E02Old Route: " + routeChosenE02);
        routeString = "Route: None";
        routeTextE06.text = routeString;

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;


        if (routeChosenE06 == 1)
        {
            Route01RemoveIncome();
        }
        if (routeChosenE06 == 2)
        {
            Route02RemoveIncome();
        }
        if (routeChosenE06 == 3)
        {
            Route03RemoveIncome();
        }
        if (routeChosenE06 == 4)
        {
            Route04RemoveIncome();
        }
        if (routeChosenE06 == 5)
        {
            Route05RemoveIncome();
        }
        if (routeChosenE06 == 6)
        {
            Route06RemoveIncome();
        }

        routeChosenE06 = 0;
    }


    public void OldRouteE07()
    {
        //Debug.Log("E02Old Route: " + routeChosenE02);
        routeString = "Route: None";
        routeTextE07.text = routeString;

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;


        if (routeChosenE07 == 1)
        {
            Route01RemoveIncome();
        }
        if (routeChosenE07 == 2)
        {
            Route02RemoveIncome();
        }
        if (routeChosenE07 == 3)
        {
            Route03RemoveIncome();
        }
        if (routeChosenE07 == 4)
        {
            Route04RemoveIncome();
        }
        if (routeChosenE07 == 5)
        {
            Route05RemoveIncome();
        }
        if (routeChosenE07 == 6)
        {
            Route06RemoveIncome();
        }

        routeChosenE07 = 0;
    }

    public void OldRouteE08()
    {
        //Debug.Log("E02Old Route: " + routeChosenE02);
        routeString = "Route: None";
        routeTextE08.text = routeString;

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;


        if (routeChosenE08 == 1)
        {
            Route01RemoveIncome();
        }
        if (routeChosenE08 == 2)
        {
            Route02RemoveIncome();
        }
        if (routeChosenE08 == 3)
        {
            Route03RemoveIncome();
        }
        if (routeChosenE08 == 4)
        {
            Route04RemoveIncome();
        }
        if (routeChosenE08 == 5)
        {
            Route05RemoveIncome();
        }
        if (routeChosenE08 == 6)
        {
            Route06RemoveIncome();
        }

        routeChosenE08 = 0;
    }

    public void OldRouteE09()
    {
        //Debug.Log("E02Old Route: " + routeChosenE02);
        routeString = "Route: None";
        routeTextE09.text = routeString;

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;


        if (routeChosenE09 == 1)
        {
            Route01RemoveIncome();
        }
        if (routeChosenE09 == 2)
        {
            Route02RemoveIncome();
        }
        if (routeChosenE09 == 3)
        {
            Route03RemoveIncome();
        }
        if (routeChosenE09 == 4)
        {
            Route04RemoveIncome();
        }
        if (routeChosenE09 == 5)
        {
            Route05RemoveIncome();
        }
        if (routeChosenE09 == 6)
        {
            Route06RemoveIncome();
        }

        routeChosenE09 = 0;
    }

    public void OldRouteE10()
    {
        //Debug.Log("E02Old Route: " + routeChosenE02);
        routeString = "Route: None";
        routeTextE10.text = routeString;

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;


        if (routeChosenE10 == 1)
        {
            Route01RemoveIncome();
        }
        if (routeChosenE10 == 2)
        {
            Route02RemoveIncome();
        }
        if (routeChosenE10 == 3)
        {
            Route03RemoveIncome();
        }
        if (routeChosenE10 == 4)
        {
            Route04RemoveIncome();
        }
        if (routeChosenE10 == 5)
        {
            Route05RemoveIncome();
        }
        if (routeChosenE10 == 6)
        {
            Route06RemoveIncome();
        }

        routeChosenE10 = 0;
    }

    public void OldRouteE11()
    {
        //Debug.Log("E02Old Route: " + routeChosenE02);
        routeString = "Route: None";
        routeTextE11.text = routeString;

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;


        if (routeChosenE11 == 1)
        {
            Route01RemoveIncome();
        }
        if (routeChosenE11 == 2)
        {
            Route02RemoveIncome();
        }
        if (routeChosenE11 == 3)
        {
            Route03RemoveIncome();
        }
        if (routeChosenE11 == 4)
        {
            Route04RemoveIncome();
        }
        if (routeChosenE11 == 5)
        {
            Route05RemoveIncome();
        }
        if (routeChosenE11 == 6)
        {
            Route06RemoveIncome();
        }

        routeChosenE11 = 0;
    }

    public void OldRouteE12()
    {
        //Debug.Log("E02Old Route: " + routeChosenE02);
        routeString = "Route: None";
        routeTextE12.text = routeString;

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;


        if (routeChosenE12 == 1)
        {
            Route01RemoveIncome();
        }
        if (routeChosenE12 == 2)
        {
            Route02RemoveIncome();
        }
        if (routeChosenE12 == 3)
        {
            Route03RemoveIncome();
        }
        if (routeChosenE12 == 4)
        {
            Route04RemoveIncome();
        }
        if (routeChosenE12 == 5)
        {
            Route05RemoveIncome();
        }
        if (routeChosenE12 == 6)
        {
            Route06RemoveIncome();
        }

        routeChosenE12 = 0;
    }

    public void OldRouteE13()
    {
        //Debug.Log("E02Old Route: " + routeChosenE02);
        routeString = "Route: None";
        routeTextE13.text = routeString;

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;


        if (routeChosenE13 == 1)
        {
            Route01RemoveIncome();
        }
        if (routeChosenE13 == 2)
        {
            Route02RemoveIncome();
        }
        if (routeChosenE13 == 3)
        {
            Route03RemoveIncome();
        }
        if (routeChosenE13 == 4)
        {
            Route04RemoveIncome();
        }
        if (routeChosenE13 == 5)
        {
            Route05RemoveIncome();
        }
        if (routeChosenE13 == 6)
        {
            Route06RemoveIncome();
        }

        routeChosenE13 = 0;
    }

    public void OldRouteE14()
    {
        //Debug.Log("E02Old Route: " + routeChosenE02);
        routeString = "Route: None";
        routeTextE14.text = routeString;

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;


        if (routeChosenE14 == 1)
        {
            Route01RemoveIncome();
        }
        if (routeChosenE14 == 2)
        {
            Route02RemoveIncome();
        }
        if (routeChosenE14 == 3)
        {
            Route03RemoveIncome();
        }
        if (routeChosenE14 == 4)
        {
            Route04RemoveIncome();
        }
        if (routeChosenE14 == 5)
        {
            Route05RemoveIncome();
        }
        if (routeChosenE14 == 6)
        {
            Route06RemoveIncome();
        }

        routeChosenE14 = 0;
    }
    



    public void OnPointerClick(PointerEventData eventData)
    {
        int rc = RouteChoose.routeNumberStatic;

        //Debug.Log(EmployeeHiring.speedStatic);
        //Debug.Log(EmployeeHiring.strengthStatic);

        //Debug.Log(Random.Range(1,10));

        //a = GameObject.Find("Employees").GetComponents<Employees.speed>();

        shareSpeed = EmployeeExtra.speedStatic; //EmployeeExtra.speedSharing; //EmployeeHiring.speedStatic; //not updated when firing employees
        shareStrength = EmployeeExtra.strengthStatic; //EmployeeHiring.strengthStatic; EmployeeExtra.strengthSharing;

        //Debug.Log("RouteToWork" + shareSpeed + " + " + shareStrength);

        if (EmployeeExtra.employeeNumberStatic == 1)
        {
            //if (has iron pickaxe)
            //{
            //IronMiningAllowed = true
            //}

            OldRouteE01(); // before or after pickaxe check?
        }

        if (EmployeeExtra.employeeNumberStatic == 2)
        {
            OldRouteE02();
        }

        if (EmployeeExtra.employeeNumberStatic == 3)
        {
            OldRouteE03();
        }

        if (EmployeeExtra.employeeNumberStatic == 4)
        {
            OldRouteE04();
        }

        if (EmployeeExtra.employeeNumberStatic == 5)
        {
            OldRouteE05();
        }

        if (EmployeeExtra.employeeNumberStatic == 6)
        {
            OldRouteE06();
        }

        if (EmployeeExtra.employeeNumberStatic == 7)
        {
            OldRouteE07();
        }

        if (rc == 1)
        {
            workersRoute01 += 1; //sent another worker on this route
            routeString = "Route: Basic Minerals";

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
            routeString = "Route: Interesting Mix";

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
            routeString = "Route: Long Haul";

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
            routeString = "Route: Dangerous Extraction";

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
            routeString = "Route: Heavy Metal";

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
            routeString = "Route: Shiny";

            //gain rocks, silver, gold
            PlayerStats.gatheringSpeedRocks += shareSpeed;
            PlayerStats.gatheringStrengthRocks += shareStrength;
            PlayerStats.gatheringSpeedSilver += shareSpeed;
            PlayerStats.gatheringStrengthSilver += shareStrength;
            PlayerStats.gatheringSpeedGold += shareSpeed;
            PlayerStats.gatheringStrengthGold += shareStrength;
        }


        if (EmployeeExtra.employeeNumberStatic == 1)
        {
            //bool, employee on route
            //disable CHOOSE ROUSE button
            //enable the cancelRoute button

            //if (routeTextE01.text == "Route: Basic Minerals")
            //{
            //    routeChosenE01 = rc;
                //Debug.Log("E01Old Route: " + routeChosenE01);
            //}

            //get the stats from the employee
            //reset allocation of speed and strength points
            //allocate speed and strength points to the new route
            //??deselect
            //??add bool, to say he's already sent out
            //disable the ssend button if already sent out , use a bool

            routeChosenE01 = rc; //registers route chosen
            routeTextE01.text = routeString; //changes the route on the info board
        }

        if (EmployeeExtra.employeeNumberStatic == 2)
        {
            routeChosenE02 = rc;
            routeTextE02.text = routeString;
        }

        if (EmployeeExtra.employeeNumberStatic == 3)
        {
            routeChosenE03 = rc;
            routeTextE03.text = routeString;
        }

        if (EmployeeExtra.employeeNumberStatic == 4)
        {
            routeChosenE04 = rc;
            routeTextE04.text = routeString;
        }

        if (EmployeeExtra.employeeNumberStatic == 5)
        {
            routeChosenE05 = rc;
            routeTextE05.text = routeString;
        }

        if (EmployeeExtra.employeeNumberStatic == 6)
        {
            routeChosenE06 = rc;
            routeTextE06.text = routeString;
        }

        if (EmployeeExtra.employeeNumberStatic == 7)
        {
            routeChosenE07 = rc;
            routeTextE07.text = routeString;
        }

        //deselect
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
