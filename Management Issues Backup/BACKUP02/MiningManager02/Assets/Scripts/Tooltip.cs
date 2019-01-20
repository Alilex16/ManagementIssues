using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Tooltip : MonoBehaviour {

    public Vector3 offset;
    

    // Use this for initialization


    void OnEnable()
    {
        Vector3 pos = Input.mousePosition;
        transform.position = pos + offset;
    }

    // Update is called once per frame
    void Update ()
    {
        Vector3 pos = Input.mousePosition;
        transform.position = pos + offset;
		
	}
}
