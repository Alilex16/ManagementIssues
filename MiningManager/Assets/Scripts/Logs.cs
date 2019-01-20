using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Logs : MonoBehaviour, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject mainMenu; //to sell
    
    public GameObject workshopMenu; //
    
    public GameObject sellAmount;

    public static int logNumberStatic;
    public int logNumber; //set a unique number for each skill


    private bool isDragable;

    public void OnPointerClick(PointerEventData eventData) // NEW SCRIPT FOR SELLING THIS
    {
        logNumberStatic = logNumber;

        if (mainMenu.activeInHierarchy == true) // can only sell while in main menu
        {
            sellAmount.SetActive(true);
            EventSystem.current.SetSelectedGameObject(sellAmount, null); //allows sale input straight away

            Sell.instance.ResetInputField(); //forgets previous entry
        }
    }


    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;

    public GameObject inventoryContentLocation; //place to return after clicking // WILL MOST LIKELY THIS MESS WITH THE FILTER SYSTEM?

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!workshopMenu.activeInHierarchy)
        {
            isDragable = false;
        }
        else
        {
            isDragable = true;
        }

        if (!isDragable)
            return;

        logNumberStatic = logNumber; //
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().alpha = 0.7f;
        GetComponent<CanvasGroup>().blocksRaycasts = false; //blocks raycasts
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!workshopMenu.activeInHierarchy)
        {
            isDragable = false;
        }
        else
        {
            isDragable = true;
        }

        if (!isDragable)
            return;

        transform.position = Input.mousePosition;
    }


    public void OnEndDrag(PointerEventData eventData)
    {
        if (!workshopMenu.activeInHierarchy)
        {
            isDragable = false;
        }
        else
        {
            isDragable = true;
        }

        if (!isDragable)
            return;

        itemBeingDragged = null;
        GetComponent<CanvasGroup>().alpha = 1f;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        if (transform.parent == startParent)
        {
            transform.position = startPosition;
        }
        //transform.position = startPosition;
    }
}
