using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;

public class RandomEmployees : MonoBehaviour {

    
    //MOVE THIS SCRIPT TO MANAGER!!!!


    public GameObject employeeToClone;

    public GameObject employeeInfo;

    public GameObject mainMenu;


    //public GameObject employeeInfoToClone;

    //public GameObject toHireInformationBoard;
    public GameObject toHireContent;

    public ScriptableObject employeeBaseSO;

    private Transform toHireTransform;

    private float renewRoster;
    
    public void Start()
    {
        //GameObject employee = (GameObject)Instantiate(toClone);
        //ScriptableObject employee = (ScriptableObject)Instantiate(toClone);

        //GameObject clone = Instantiate(toClone);


        //employee.transform.SetParent(transform, false);
        
    }


    //GameObject copy = (GameObject)Instantiate(Ores.itemBeingDragged);
    //instantiate 



    void Update()
    {
        renewRoster += Time.deltaTime;

        if (renewRoster >= 15)
        {
            //Debug.Log("gem check is done");
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


        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    EmployeeRandomizer();
        //}

    }

    public void EmployeeRandomizer()
    {
        //GameObject employeeInfo = (GameObject)Instantiate(employeeInfoToClone);
        //employeeInfo.transform.SetParent(transform, false);
        //employeeInfo.transform.SetParent(toHireTransform, false);

        //employeeInfo.SetActive(true);

        //employeeInfo.SetActive(false);

        //Debug.Log(employee.fatigue.ToString());
        
        toHireTransform = toHireContent.GetComponent<Transform>();

        GameObject employee = (GameObject)Instantiate(employeeToClone);
        employee.transform.SetParent(toHireTransform, false);

        employee.SetActive(true);

    }

    public void ClearRoster()
    {
        //Destroy(transform.GetChild(0).gameObject);



        //foreach(Transform child in transform)
        //{
        //    GameObject.Destroy(child.gameObject);
        //}

        toHireTransform = toHireContent.GetComponent<Transform>();

        foreach (Transform child in toHireTransform)
        {
            if (child.gameObject.activeInHierarchy)
            {
                GameObject.Destroy(child.gameObject);
            }
        }

        if (mainMenu.activeInHierarchy)
        {
            employeeInfo.SetActive(false);
        }

    }

}
