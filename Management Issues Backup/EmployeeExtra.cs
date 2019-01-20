using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EmployeeExtra : MonoBehaviour, IPointerClickHandler {
    
    public int employeeNumber;
    //public static int employeeNumberStatic;
    
    public GameObject info;

    public GameObject chooseRoute;
    

    public void OnPointerClick(PointerEventData eventData)
    {
        chooseRoute.GetComponent<Dropdown>().interactable = true;

        //employeeNumberStatic = employeeNumber;

        employeeNumber = EmployeeHiring.employeeNumberStatic;

        // DONT FORGET THIS SHIT
        //PlayerStats.instance.DeactivateEmployeesToHireList();
        //

        info.SetActive(true);
        
    }
    
}
