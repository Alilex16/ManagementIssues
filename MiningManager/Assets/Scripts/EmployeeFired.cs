using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EmployeeFired : MonoBehaviour, IPointerClickHandler
{

    public GameObject employee;
    public static GameObject employeeStatic; // Used @ ExmployeesExtra

    public GameObject firedEmployee;

    public GameObject chooseRoute; // !interactable
    public GameObject routeWorkButton; //!isActive


    //RouteToWork routeToWork;

    //void Start()
    //{
    //    routeToWork = RouteToWork.instance;
    //}
    
    
    public void OnPointerClick(PointerEventData eventData)
    {
        chooseRoute.GetComponent<Dropdown>().interactable = false;
        routeWorkButton.SetActive(false);

        if (StartMining.isUsed == true)
        {
            ResetMiningIncome();
        }

        GetFired();
    }

    public void GetFired()
    {
        PlayerStats.employeesHired -= 1;
        //RectTransform rect = GetComponent<RectTransform>();

        employee = employeeStatic;

        employee.transform.SetParent(firedEmployee.transform); //, false?
        transform.parent.gameObject.SetActive(false);
    }


    private string tempInt;
    private GameObject onlyThisEmployee;
    private Text thisText;

    public void ResetMiningIncome()
    {
        StartMining.instance.OldRoute();
        

        tempInt = EmployeeExtra.employeeNumberStatic.ToString(); //get the employee ID number

        onlyThisEmployee = GameObject.Find(tempInt); //find the corresponding gameObject

        thisText = onlyThisEmployee.GetComponentInChildren<Text>(); //use the text in its child

        thisText.text = "";

        EmployeeHiring.employeeRouteStaticText = ""; //EmployeeExtra.displayRoute = thisText.text; -> doesn't work
        
    }

}