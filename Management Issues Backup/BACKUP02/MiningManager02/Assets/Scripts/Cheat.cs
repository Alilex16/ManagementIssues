using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cheat : MonoBehaviour
{

    public void Cheating()
    {
        if (GetComponent<Toggle>().isOn)
        {
            Time.timeScale = 100; //speed 100 times faster
        }
        else
        {
            Time.timeScale = 1; //speed back to normal
        }

    }




}
