using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EmployeeHired : MonoBehaviour, IPointerClickHandler
{
    
    public GameObject employee; 
    public static GameObject employeeStatic; // Used @ ExmployeesExtra
    //public GameObject employeeInfo;

    public GameObject hiredEmployee;
    

    public void OnPointerClick(PointerEventData eventData)
    {
        if (EmployeeExtra.salaryEmployee <= PlayerStats.totalEuroAmount)
        {
            PlayerStats.totalEuroAmount -= EmployeeExtra.salaryEmployee;

            //resets the position after hiring
            //Vector3 pos = new Vector3(0, 0, 0);

            //employee.transform.localPosition = pos;
            //employeeInfo.transform.localPosition = pos;

            GetHired();
        }
        else
        {
            Debug.Log("Not enough money to hire this employee");
        }
    }

    public void GetHired()
    {
        PlayerStats.employeesHired += 1;
        //RectTransform rect = GetComponent<RectTransform>();

        //Employees employee = EmployeeExtra.employeeStatic;
        
        employee = employeeStatic;

        employee.transform.SetParent(hiredEmployee.transform, false); //, false?
        
        transform.parent.gameObject.SetActive(false);
        
    }
    
}