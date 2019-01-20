using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfEmployees : MonoBehaviour {

    public GameObject ToHireContent;

    public int childCount;


	void Start ()
    {

        //childCount = ToHireContent.transform.GetChildCount();
        childCount = ToHireContent.transform.childCount;

        Debug.Log("Child count: " + childCount);
        

        List<int> randomNumbers = new List<int>
        {
            Random.Range(0, childCount), //max amount of available employees for hire
            Random.Range(0, childCount),
            Random.Range(0, childCount),
            Random.Range(0, childCount),
            Random.Range(0, childCount)
        };

        //Debug.Log(randomNumbers[0]);
        //Debug.Log(randomNumbers[1]);
        

        //there's a max of 5 employees available for hire //set a timer to switch things around
        GameObject employeeA = ToHireContent.transform.GetChild(randomNumbers[0]).gameObject;
        GameObject employeeB = ToHireContent.transform.GetChild(randomNumbers[1]).gameObject;
        GameObject employeeC = ToHireContent.transform.GetChild(randomNumbers[2]).gameObject;
        GameObject employeeD = ToHireContent.transform.GetChild(randomNumbers[3]).gameObject;
        GameObject employeeE = ToHireContent.transform.GetChild(randomNumbers[4]).gameObject;


        employeeA.SetActive(true);
        employeeB.SetActive(true);
        employeeC.SetActive(true);
        employeeD.SetActive(true);
        employeeE.SetActive(true);
        

        //Debug.Log(employeeA);
    }





}
