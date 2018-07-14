using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Ores : MonoBehaviour, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject mainMenu; //to sell
    public GameObject smithyMenu; //to Smelt

    public GameObject sellAmount;

    public static int oreNumberStatic;
    public int oreNumber; //set a unique number for each skill


    private bool isDragable;

    public void OnPointerClick(PointerEventData eventData)
    {

        oreNumberStatic = oreNumber;
        
        if (mainMenu.activeInHierarchy == true) // can only sell while in main menu
        {
            //Debug.Log("main menu active");
            //use the selling buttons
            sellAmount.SetActive(true);
            //sellAmount.transform.GetComponent<InputField>().isFocused;
            EventSystem.current.SetSelectedGameObject(sellAmount, null); //allows sale input straight away

            Sell.instance.ResetInputField();
        }
    }
    

    public static GameObject itemBeingDragged;
    Vector3 startPosition;
    Transform startParent;

    public GameObject inventoryContentLocation; //place to return after clicking

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!smithyMenu.activeInHierarchy)
        {
            isDragable = false;
        }
        else
        {
            isDragable = true;
        }

        if (!isDragable)
            return;

        oreNumberStatic = oreNumber; //
        itemBeingDragged = gameObject;
        startPosition = transform.position;
        startParent = transform.parent;
        GetComponent<CanvasGroup>().alpha = 0.7f;
        GetComponent<CanvasGroup>().blocksRaycasts = false; //blocks raycasts
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!smithyMenu.activeInHierarchy)
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
        if (!smithyMenu.activeInHierarchy)
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
