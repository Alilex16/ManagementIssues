using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EmployeeExtra : MonoBehaviour, IPointerClickHandler {

    //prop [+tab tab]
    //public int MyProperty { get; set; }
    
        //propful [+ tab tab]
    private int myVar;

    public int MyProperty
    {
        get { return myVar; }
        protected set
        {
            if (value < 0)
            {
                return;
            }
            myVar = value;
        }
    }

    private void MyMethod()
    {
        MyProperty = 5;
        int a = MyProperty;
        MyProperty = -10;

    }
    
    public static int employeeNumberStatic;
    
    public Text displayName;
    private string displayDescription;

    private string displaySpeed;
    private string displayStrength;
    private string displaySalary;
    public string displayNumber; //change to private
    public static string displayRoute; //change to private
    
    [SerializeField]
    private GameObject miningMenu;

    [SerializeField]
    private GameObject forestryMenu;

    [SerializeField]
    private GameObject info;
    public GameObject Info
    {
        get
        {
            return info;
        }
    }

    [SerializeField]
    private GameObject chooseRouteMining;

    [SerializeField]
    private GameObject chooseRouteForestry;

    [SerializeField]
    private Employee employee;
    
    private int listNamesInt;
    private int listDescriptionsInt;


    public static EmployeeExtra instance;

    void Awake()
    {
        instance = this;
    }


    void Start()
    {
        List<string> listOfNames = new List<string>
        {
            "Alex",
            "Agnes",
            "Amy",

            "Astrid",
            "Bob",

            "Christina",
            "Corina",
            "Csilla",
            "Daisy",
            "Diana",
            "Eric",

            "Gemma",
            "Jeffery",
            "Jennifer",

            "Jerome",
            "Joey",
            "Marita",
            "Martin",
            "Maus",
            "Michael",
            "Michaela",

            "Paula",

            "Roelof",
            "Rudolf",
            "Stephanie",
            "Wouter",


        };


        //use dictionary instead of list. Specify this better, eg: "Hates Bob' will not be placed on "Bob". 

        List<string> listOfDescriptions = new List<string>
        {
            "The best of like, everything.",
            "Hates Bob.",
            "If you're happy and you know it.",
            "Does drink.",
            "Forever young and happy.",
            "Loves to joke around.",
            "Psst, did you hear about this guy?",
            "Glad to be single.",
            "Just an average worker.",
            "Not quite the parent.",
            "Waiting to win the lottery.",
            "Look at me, I'm smart.",
            "Seriously quiet type. Too cool for you.",
            "Big mouth, but a heart of gold.",
            "Has the most beautiful hair.",
            "Usually a bit late.",
            "Party Hardy.",
            "Take it easy.",

            "Living the life!",
            "Go with the flow.",
            "Try again.",
            "Length: 1.75m. Too high for my taste.",
            "As secretive as can be.",

            "Wanna hear a funny story? Yeah, I ain't tellin'.",

            "Life's rough.",
            "See this? Me neither.",

            "Wanted to build a wall he said. Not happening.",
            "Stop Twittering. Start doing your job.",
            "Sarcasm is definately not one of my quirks.",
        };


        listNamesInt = listOfNames.Count;
        listDescriptionsInt = listOfDescriptions.Count;


        //name + description
        //employee.employeeName = dictionaryNames[Random.Range(0, dictionaryNamesInt)]; //dictionary.Count = amount of entries in the dictionary
        employee.employeeName = listOfNames[Random.Range(0, listNamesInt)]; //dictionary.Count = amount of entries in the dictionary
        employee.description = listOfDescriptions[Random.Range(0, listDescriptionsInt)];

        employee.speed = Random.Range(1, 11);
        employee.strength = Random.Range(1, 11);
        //
        employee.salary = CalculateSalary(); //include specialty?? // other factors??

        
        employee.employeeNumber += 1;


        displayName.text = employee.employeeName.ToString();
        displayDescription = employee.description.ToString();
        displaySpeed = employee.speed.ToString();
        displayStrength = employee.strength.ToString();
        displaySalary = employee.salary.ToString();

        displayNumber = employee.employeeNumber.ToString();


        name = displayNumber; //changes the name of the gameobject, to its unique number


    }

    private int CalculateSalary()
    {
        return 100 + (Random.Range(8, 10) * (employee.speed + employee.strength + (employee.speed * employee.strength)));
    }
    

    public static int speedStatic;
    public static int strengthStatic;
    
    

    public void OnPointerClick(PointerEventData eventData)
    {
        //displayRoute = employee.route.ToString(); //nbeed to set employeeRoute in a function in this script to update to current route

        displayRoute = GetComponentInChildren<Text>().text;

        //Debug.Log("Current Route: " + displayRoute);
        
        EmployeeHiring.employeeNameStaticText = displayName.text.ToString();
        EmployeeHiring.employeeDescriptionStaticText = displayDescription.ToString();
        EmployeeHiring.employeeSpeedStaticInt = displaySpeed.ToString();
        EmployeeHiring.employeeStrengthStaticInt = displayStrength.ToString();
        EmployeeHiring.employeeSalaryStaticInt = displaySalary.ToString();

        EmployeeHiring.employeeRouteStaticText = displayRoute.ToString(); //displays the actual route of the employee


        int.TryParse(displaySpeed.ToString(), out speedStatic);
        int.TryParse(displayStrength.ToString(), out strengthStatic);
        
        int.TryParse(displaySalary.ToString(), out EmployeeHired.salaryEmployeeStaticInt);
        

        //employeeNumberStatic = displayNumber.ToString();
        int.TryParse(displayNumber.ToString(), out employeeNumberStatic);

        EmployeeHiring.employeeNumberStatic = employeeNumberStatic;


        if (miningMenu.activeInHierarchy)
        {
            chooseRouteMining.GetComponent<Dropdown>().interactable = true;
        }

        if (forestryMenu.activeInHierarchy)
        {
            chooseRouteForestry.GetComponent<Dropdown>().interactable = true;
        }
        
        
        EmployeeHired.employeeStatic = this.gameObject;
        EmployeeFired.employeeStatic = this.gameObject;
        
        StartMining.employeeChosen = this.gameObject; // is this even used??

        //PlayerStats.instance.DeactivateEmployeesToHireList();

        info.SetActive(true);
        
    }
}
