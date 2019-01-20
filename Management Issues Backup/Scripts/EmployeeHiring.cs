using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[System.Serializable]
public class EmployeeHiring : MonoBehaviour
{
    public int employeeNumber;
    public static int employeeNumberStatic;

    public Text employeeNameText;
    public static string employeeNameStaticText;

    public Text descriptionText;
    public static string employeeDescriptionStaticText;

    public Text fatigueText;


    public Text speedText;
    public static string employeeSpeedStaticInt;

    public Text strengthText;
    public static string employeeStrengthStaticInt;
    
    public Text salaryText;
    public static string employeeSalaryStaticInt;


    public Text specialtyText;


    public Text routeText;



    public static EmployeeHiring instance;

    void Awake()
    {
        instance = this;
    }

    

    void Start()
    {
        
 

        //employeeNameText.text = employee.employeeName;
        //descriptionText.text = EmployeeExtra.description;

        //employeeNumber = EmployeeExtra.employeeNumberStatic;

        //fatigueText.text = "Fatigue: " + EmployeeExtra.fatigue.ToString() + " / 235";
        //speedText.text = "Speed: " + EmployeeExtra.speed.ToString();
        //strengthText.text = "Strength: " + EmployeeExtra.strength.ToString();

        //salaryText.text = "Salary: € " + EmployeeExtra.salary + " per month";
        //specialtyText.text = "Specialty: " + EmployeeExtra.specialty.ToString();
        //routeText.text = "Route: " + EmployeeExtra.route.ToString();//


        //Debug.Log(employee.speed);
    }

    public void Update() //use a function instead of update
    {
        employeeNameText.text = employeeNameStaticText.ToString();
        descriptionText.text = employeeDescriptionStaticText.ToString();
        speedText.text = "Speed: " + employeeSpeedStaticInt.ToString();
        strengthText.text = "Strength: " + employeeStrengthStaticInt.ToString();
        salaryText.text = "Salary: € " + employeeSalaryStaticInt.ToString() + " per month";

        employeeNumber = employeeNumberStatic;

        //employeeNumberStatic = employeeNumber;
        //speedStatic = employee.speed;
        //strengthStatic = employee.strength;
        //salaryEmployee = employee.salary;

        //routeTextStatic.text = "Route: " + employeeStatic.route.ToString();//
    }


}
