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
        if (PlayerStats.employeesHired != 0)
        {
            employeeInfo.transform.SetParent(toFireBoard.transform, false);
            hireButton.SetActive(false);
            fireButton.SetActive(true);
            employeeInfo.SetActive(false);
        }
        
    }
    
}