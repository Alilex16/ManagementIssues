using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EmployeeFired : MonoBehaviour, IPointerClickHandler
{

    public GameObject employee;
    public static GameObject employeeStatic; // Used @ ExmployeesExtra
    //public GameObject employeeInfo;

    public GameObject firedEmployee;
    //public GameObject fireEmployeeInfo;

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

        if (RouteToWork.isUsed == true)
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
                                                               
        //employeeInfo.transform.SetParent(fireEmployeeInfo.transform);
        
        transform.parent.gameObject.SetActive(false);
        
    }


    //these used to be private
    private string tempInt;
    private GameObject onlyThisEmployee;
    private Text thisText;

    public void ResetMiningIncome()
    {
        RouteToWork.instance.OldRoute();
        

        tempInt = EmployeeExtra.employeeNumberStatic.ToString(); //get the employee ID number

        onlyThisEmployee = GameObject.Find(tempInt); //find the corresponding gameObject

        thisText = onlyThisEmployee.GetComponentInChildren<Text>(); //use the text in its child

        thisText.text = "";

        EmployeeHiring.employeeRouteStaticText = ""; //EmployeeExtra.displayRoute = thisText.text; -> doesn't work
        
        //if (EmployeeHiring.employeeNumberStatic == 1)
        //{
        //    RouteToWork.instance.OldRouteE01();
        //    //routeToWork.OldRouteE01();
        //}

    }

}