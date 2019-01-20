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



    //RouteToWork routeToWork;

    //void Start()
    //{
    //    routeToWork = RouteToWork.instance;
    //}


    
    public void OnPointerClick(PointerEventData eventData)
    {
        GetFired();
        ResetMiningIncome();        
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

    public void ResetMiningIncome()
    {
        //if (EmployeeHiring.employeeNumberStatic == 1)
        //{
        //    RouteToWork.instance.OldRouteE01();
        //    //routeToWork.OldRouteE01();
        //}

    }

}