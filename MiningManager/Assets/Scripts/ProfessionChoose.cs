using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ProfessionChoose : MonoBehaviour, IPointerClickHandler
{

    [Header("Placeholder")]
    public GameObject professionButtons;


    public void OnPointerClick(PointerEventData eventData)
    {
        if (professionButtons.activeInHierarchy)
        {
            professionButtons.SetActive(false);
        }
        else
        {
            professionButtons.SetActive(true);
        }
    }
}
