using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventoryManager : MonoBehaviour
{

    [Header("Buttons")]
    [SerializeField]
    private GameObject buttonOres;

    [SerializeField]
    private GameObject buttonGems;

    [SerializeField]
    private GameObject buttonIngots;
    
    [SerializeField]
    private GameObject buttonLogs;

    [Header("Contents")]
    [SerializeField]
    private GameObject contentOres;
    
    [SerializeField]
    private GameObject contentGems;

    [SerializeField]
    private GameObject contentIngots;

    [SerializeField]
    private GameObject contentLogs;

    [SerializeField]
    private GameObject contentAll;
    
    private Button oresButton;
    private Button gemsButton;
    private Button ingotsButton;
    private Button logsButton;

    private CanvasGroup buttonOresAlpha;
    private CanvasGroup buttonGemsAlpha;
    private CanvasGroup buttonIngotsAlpha;
    private CanvasGroup buttonLogsAlpha;
    
    private bool isOnOre;
    private bool isOnGem;
    private bool isOnIngot;
    private bool isOnLog;
    
    private List<GameObject> oresObjectsList = new List<GameObject>();
    private List<GameObject> gemsObjectsList = new List<GameObject>();
    private List<GameObject> ingotsObjectsList = new List<GameObject>();
    private List<GameObject> logsObjectsList = new List<GameObject>();


    void Start()
    {
        Initialize();

        FillLists();

        ShowOres();
        ShowGems();
        ShowIngots();
        ShowLogs();
    }

    public void Initialize()
    {
        buttonOresAlpha = buttonOres.GetComponent<CanvasGroup>();
        buttonGemsAlpha = buttonGems.GetComponent<CanvasGroup>();
        buttonIngotsAlpha = buttonIngots.GetComponent<CanvasGroup>();
        buttonLogsAlpha = buttonLogs.GetComponent<CanvasGroup>();

        oresButton = buttonOres.GetComponent<Button>();
        gemsButton = buttonGems.GetComponent<Button>();
        ingotsButton = buttonIngots.GetComponent<Button>();
        logsButton = buttonLogs.GetComponent<Button>();

        oresButton.onClick.AddListener(OreSorting);
        gemsButton.onClick.AddListener(GemSorting);
        ingotsButton.onClick.AddListener(IngotSorting);
        logsButton.onClick.AddListener(LogSorting);
    }


    public void FillLists()
    {
        Transform[] allOres = contentOres.GetComponentsInChildren<Transform>();
        //List<GameObject> oresObjectsList = new List<GameObject>();
        foreach (Transform child in allOres)
        {
            if (child.CompareTag ("Ore"))
            {
                oresObjectsList.Add(child.gameObject);
            }
        }

        Transform[] allGems = contentGems.GetComponentsInChildren<Transform>();
        foreach (Transform child in allGems)
        {
            if (child.CompareTag("Gem"))
            {
                gemsObjectsList.Add(child.gameObject);
            }
        }

        Transform[] allIngots = contentIngots.GetComponentsInChildren<Transform>();
        foreach (Transform child in allIngots)
        {
            if (child.CompareTag("Ingot"))
            {
                ingotsObjectsList.Add(child.gameObject);
            }
        }

        Transform[] allLogs = contentLogs.GetComponentsInChildren<Transform>();
        foreach (Transform child in allLogs)
        {
            if (child.CompareTag("Log"))
            {
                logsObjectsList.Add(child.gameObject);
            }
        }
    }
    
    private void OreSorting()
    {
        if (isOnOre)
        {
            ShowOres();
        }
        else
        {
            HideOres();
        }
    }

    private void GemSorting()
    {
        if (isOnGem)
        {
            ShowGems();
        }
        else
        {
            HideGems();
        }
    }

    private void IngotSorting()
    {
        if (isOnIngot)
        {
            ShowIngots();
        }
        else
        {
            HideIngots();
        }
    }

    private void LogSorting()
    {
        if (isOnLog)
        {
            ShowLogs();
        }
        else
        {
            HideLogs();
        }
    }

    private void HideOres()
    {
        foreach (GameObject ore in oresObjectsList)
        {
            ore.transform.SetParent(contentOres.transform);
        }

        buttonOresAlpha.alpha = 0.6f;
        isOnOre = true;
    }

    private void ShowOres()
    {
        foreach (GameObject ore in oresObjectsList)
        {
            ore.transform.SetParent(contentAll.transform);
        }
        buttonOresAlpha.alpha = 1f;
        isOnOre = false;
    }

    private void HideGems()
    {
        foreach (GameObject gem in gemsObjectsList)
        {
            gem.transform.SetParent(contentGems.transform);
        }

        buttonGemsAlpha.alpha = 0.6f;
        isOnGem = true;
    }

    private void ShowGems()
    {
        foreach (GameObject gem in gemsObjectsList)
        {
            gem.transform.SetParent(contentAll.transform);
        }
        buttonGemsAlpha.alpha = 1f;
        isOnGem = false;
    }


    private void HideIngots()
    {
        foreach (GameObject ingot in ingotsObjectsList)
        {
            ingot.transform.SetParent(contentIngots.transform);
        }

        buttonIngotsAlpha.alpha = 0.6f;
        isOnIngot = true;
    }

    private void ShowIngots()
    {
        foreach (GameObject ingot in ingotsObjectsList)
        {
            ingot.transform.SetParent(contentAll.transform);
        }
        buttonIngotsAlpha.alpha = 1f;
        isOnIngot = false;
    }


    private void HideLogs()
    {
        foreach (GameObject log in logsObjectsList)
        {
            log.transform.SetParent(contentLogs.transform);
        }

        buttonLogsAlpha.alpha = 0.6f;
        isOnLog = true;
    }

    private void ShowLogs()
    {
        foreach (GameObject log in logsObjectsList)
        {
            log.transform.SetParent(contentAll.transform);
        }
        buttonLogsAlpha.alpha = 1f;
        isOnLog = false;
    }
}
