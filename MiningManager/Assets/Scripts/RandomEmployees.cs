using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class RandomEmployees : MonoBehaviour {
    
    public GameObject employeeToClone;
    public GameObject employeeInfo;
    public GameObject mainMenu;
    
    public GameObject toHireContent;

    public ScriptableObject employeeBaseSO;

    private Transform toHireTransform;

    private float renewRoster;


    void Update()
    {
        renewRoster += Time.deltaTime;

        if (renewRoster >= 15) // renews the roster every 15 seconds -> make it a variable
        {
            renewRoster = 0;
        }


        if (renewRoster <= 0.02f)
        {
            //Removes the previous employees available for hire
            ClearRoster();
            //Create 5 randomly generated employees available for hire // Randomize the amount 3-5. // Can later be upgraded up to min +1, max +3 (Total: 4-8)
            EmployeeRandomizer();
            EmployeeRandomizer();
            EmployeeRandomizer();
            EmployeeRandomizer();
            EmployeeRandomizer();
        }
    }

    public void EmployeeRandomizer()
    {
        toHireTransform = toHireContent.GetComponent<Transform>();

        GameObject employee = (GameObject)Instantiate(employeeToClone);
        employee.transform.SetParent(toHireTransform, false);

        employee.SetActive(true);
    }

    public void ClearRoster()
    {
        toHireTransform = toHireContent.GetComponent<Transform>();

        foreach (Transform child in toHireTransform)
        {

            if (mainMenu.activeInHierarchy == false)
            {
                mainMenu.SetActive(true); //in order for the childs to be active, even while you're at other menus

                if (child.gameObject.activeInHierarchy)
                {
                    GameObject.Destroy(child.gameObject);
                }

                mainMenu.SetActive(false);
            }
            else // so the roster will be properly refereshed if you're at the mainMenu
            {
                if (child.gameObject.activeInHierarchy)
                {
                    GameObject.Destroy(child.gameObject);
                }
            }


        }

        if (mainMenu.activeInHierarchy)
        {
            employeeInfo.SetActive(false);
        }
    }
    
}
