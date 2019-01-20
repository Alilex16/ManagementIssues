using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[System.Serializable]
public class EmployeeHiring : MonoBehaviour
{

    public Employees employee;
    public static Employees employeeStatic;//

    public Text employeeNameText;
    public Text descriptionText;

    public int employeeNumber;
    public static int employeeNumberStatic;

    public Text fatigueText;
    public Text speedText;
    public Text strengthText;
    public Text salaryText;
    public Text specialtyText;
    public Text routeText;

    public static int salaryEmployee;
    public static Text routeTextStatic;//


    //public int employeeLabel;
    //public static int employeeLabelStatic;
    
    private int listNamesInt;
    private int listDescriptionsInt;


    void Start()
    {
        //DONT FORGET TO ACTIVATE AND DEACTIVATE THE EMPLOYEE TO SEE THE CHANGE!!!


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

        List<string> listOfDescriptions = new List<string>
        {
            "The best of like, everything.",
            "Hates Bob.",
            "If you're happy and you know it.",
            "He does drink.",
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


        employee.employeeNumber += 1;

        employee.salary = Random.Range (8, 10) * (employee.speed + employee.strength + (employee.speed * employee.strength)); //include specialty??
        
        employeeStatic = employee;//
        routeTextStatic = routeText;//
        //employeeLabelStatic = employeeLabel;//

        employeeNameText.text = employee.employeeName;
        descriptionText.text = employee.description;

        employeeNumber = employee.employeeNumber += 1;

        fatigueText.text = "Fatigue: " + employee.fatigue.ToString() + " / 235";
        speedText.text = "Speed: " + employee.speed.ToString();
        strengthText.text = "Strength: " + employee.strength.ToString();

        salaryText.text = "Salary: € " + employee.salary + " per month";
        specialtyText.text = "Specialty: " + employee.specialty.ToString();
        routeTextStatic.text = "Route: " + employeeStatic.route.ToString();//

        //Debug.Log(employee.speed);
    }



    public static int speedStatic;
    public static int strengthStatic;

    public void Update()
    {
        employeeNumberStatic = employeeNumber;
        speedStatic = employee.speed;
        strengthStatic = employee.strength;
        salaryEmployee = employee.salary;

        //routeTextStatic.text = "Route: " + employeeStatic.route.ToString();//
    }


}
