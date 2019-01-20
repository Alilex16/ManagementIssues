using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ManageEmployees : MonoBehaviour, IPointerClickHandler
{

    //public GameObject employeesMenu;
    //public GameObject mainMenu;
    
    public GameObject employeeInfo;
    //public GameObject toHireBoard;
    public GameObject toFireBoard;

    public GameObject hireButton;
    public GameObject fireButton;

    public void OnPointerClick(PointerEventData eventData)
    {
        employeeInfo.transform.SetParent(toFireBoard.transform, false);
        employeeInfo.SetActive(false);
        hireButton.SetActive(false);
        fireButton.SetActive(true);
        
    }
    
}