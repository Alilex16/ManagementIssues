using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EmployeeExtra : MonoBehaviour, IPointerClickHandler {
    
    private int employeeNumber;
    public static int employeeNumberStatic;
    
    public Text displayName;
    private string displayDescription;

    private string displaySpeed;
    private string displayStrength;
    private string displaySalary;
    public string displayNumber; //change to private

    public GameObject info;

    public GameObject chooseRoute;
    
    public Employees employee;
    //public static Employees employeeStatic;//
    
    public static int salaryEmployee;
    
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
            "Astrid",
            "Agnes",
            "Bob",
            "Csilla",
            "Gemma",
            "Jennifer",
            "Joey",
            "Martin",
            "Maus",
            "Michaela",
            "Roelof",
            "Rudolf",
            "Stephanie",
            "Wouter",
            "Corina",

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
        };


        listNamesInt = listOfNames.Count;
        listDescriptionsInt = listOfDescriptions.Count;


        //name + description
        //employee.employeeName = dictionaryNames[Random.Range(0, dictionaryNamesInt)]; //dictionary.Count = amount of entries in the dictionary
        employee.employeeName = listOfNames[Random.Range(0, listNamesInt)]; //dictionary.Count = amount of entries in the dictionary
        employee.description = listOfDescriptions[Random.Range(0, listDescriptionsInt)];

        employee.speed = Random.Range(1, 10);
        employee.strength = Random.Range(1, 10);
        //
        employee.salary = Random.Range(8, 10) * (employee.speed + employee.strength + (employee.speed * employee.strength)); //include specialty??
        

        employee.employeeNumber += 1;
        

        displayName.text = employee.employeeName.ToString();
        displayDescription = employee.description.ToString();
        displaySpeed = employee.speed.ToString();
        displayStrength = employee.strength.ToString();
        displaySalary = employee.salary.ToString();

        displayNumber = employee.employeeNumber.ToString();
    }



    public static int speedStatic;
    public static int strengthStatic;
    

    public void OnPointerClick(PointerEventData eventData)
    {
        EmployeeHiring.employeeNameStaticText = displayName.text.ToString();
        EmployeeHiring.employeeDescriptionStaticText = displayDescription.ToString();
        EmployeeHiring.employeeSpeedStaticInt = displaySpeed.ToString();
        EmployeeHiring.employeeStrengthStaticInt = displayStrength.ToString();
        EmployeeHiring.employeeSalaryStaticInt = displaySalary.ToString();

        //employeeNumberStatic = displayNumber.ToString();
        int.TryParse(displayNumber.ToString(), out employeeNumberStatic);

        EmployeeHiring.employeeNumberStatic = employeeNumberStatic;

        chooseRoute.GetComponent<Dropdown>().interactable = true;


        

        EmployeeHired.employeeStatic = this.gameObject;
        EmployeeFired.employeeStatic = this.gameObject;



        //employeeNumberStatic = employeeNumber;


        // DONT FORGET THIS SHIT
        //PlayerStats.instance.DeactivateEmployeesToHireList();
        //

        info.SetActive(true);
        
    }
    
}
