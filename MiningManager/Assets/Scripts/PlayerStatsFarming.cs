using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatsFarming : MonoBehaviour {
    
    [Header("All Seeds")] // Remove flat extra // testing purposes
    public static float seedFruitStrawberryAmount = 5;
    public static float seedFruitBlackberryAmount = 1;
    public static float seedFruitCyennaberryAmount = 1;

    public static float seedVegetablePotatoAmount = 10;
    public static float seedVegetableTomatoAmount = 10;

    public static float seedTreeAppleAmount = 10;
    public static float seedTreeCherryAmount = 10;

    public static float seedHerbFychiLeafAmount = 10;
    public static float seedHerbCascadymeAmount = 10;
    public static float seedHerbAvialiAmount = 10;
    public static float seedHerbWinterStalkAmount = 10;
    public static float seedHerbJadenWeedAmount = 10;
    public static float seedHerbSeadwarfPetalAmount = 10;
    
    //use lists?
    private float seedFruitTotalAmount;
    private float seedVegetableTotalAmount;
    private float seedTreeTotalAmount;
    private float seedHerbTotalAmount;


    [Header("All Products from Seeds")]
    public static float productFruitStrawberryAmount; // still to add to inventory
    public static float productFruitBlackberryAmount;
    public static float productFruitCyennaberryAmount;




    //finish this





    [Header("Seed Texts")]
    public Text seedStrawberryText;
    public Text seedBlackberryText;


    //finish this



    [Header("Placeholders")]
    public GameObject fruitPlaceholder;
    public GameObject vegetablePlaceholder;
    public GameObject treePlaceholder;
    public GameObject herbPlaceholder;

    [Header("Fruits")]
    public GameObject fruitStrawberry;
    public GameObject fruitBlackberry;
    public GameObject fruitCyennaberry;

    [Header("Vegetables")]
    public GameObject vegetablePotato;
    public GameObject vegetableTomato;

    [Header("Trees")]
    public GameObject treeApple;
    public GameObject treeCherry;

    [Header("Herbs")]
    public GameObject herbFychiLeaf;
    public GameObject herbCascadyme;
    public GameObject herbAviali;
    public GameObject herbWinterStalk;
    public GameObject herbJadenWeed;
    public GameObject herbSeadwarfPetal;


    public static PlayerStatsFarming instance;

    void Awake()
    {
        instance = this;
    }
    
    private void FixedUpdate()
    {
        if (seedFruitStrawberryAmount > 0) // Strawberry
        {
            seedStrawberryText.transform.parent.gameObject.SetActive(true);

            if (seedFruitStrawberryAmount < 10000)
            {
                seedStrawberryText.text = "" + seedFruitStrawberryAmount.ToString("0");
            }
            else
            {
                float seedFruitStrawberryAmountK;
                seedFruitStrawberryAmountK = seedFruitStrawberryAmount / 1000f;
                seedStrawberryText.text = seedFruitStrawberryAmountK.ToString("0") + "K";
            }
        }
        else
        {
            seedStrawberryText.transform.parent.gameObject.SetActive(false);
        }

        if (seedFruitBlackberryAmount > 0) // Blackberry
        {
            seedBlackberryText.transform.parent.gameObject.SetActive(true);

            if (seedFruitBlackberryAmount < 10000)
            {
                seedBlackberryText.text = "" + seedFruitBlackberryAmount.ToString("0");
            }
            else
            {
                float seedFruitBlackberryAmountK;
                seedFruitBlackberryAmountK = seedFruitBlackberryAmount / 1000f;
                seedBlackberryText.text = seedFruitBlackberryAmountK.ToString("0") + "K";
            }
        }
        else
        {
            seedBlackberryText.transform.parent.gameObject.SetActive(false);
        }

        //FINISH THIS



    }


    public void CheckSeedAmounts() //called when clicking on a patch // ChoosePlantingFarming.cs
    {
        seedFruitTotalAmount = seedFruitStrawberryAmount + seedFruitBlackberryAmount + seedFruitCyennaberryAmount;
        seedVegetableTotalAmount = seedVegetablePotatoAmount + seedVegetableTomatoAmount;
        seedTreeTotalAmount = seedTreeAppleAmount + seedTreeCherryAmount;
        seedHerbTotalAmount = seedHerbFychiLeafAmount + seedHerbCascadymeAmount + seedHerbAvialiAmount + seedHerbWinterStalkAmount + seedHerbJadenWeedAmount + seedHerbSeadwarfPetalAmount;
        
        if (seedFruitTotalAmount > 0)
        {
            fruitPlaceholder.SetActive(true);

            if (seedFruitStrawberryAmount > 0)
            {
                fruitStrawberry.SetActive(true);
            }
            if (seedFruitBlackberryAmount > 0)
            {
                fruitBlackberry.SetActive(true);
            }
            if (seedFruitCyennaberryAmount > 0)
            {
                fruitCyennaberry.SetActive(true);
            }
        }

        if (seedVegetableTotalAmount > 0)
        {
            vegetablePlaceholder.SetActive(true);

            if (seedVegetablePotatoAmount > 0)
            {
                vegetablePotato.SetActive(true);
            }
            if (seedVegetableTomatoAmount > 0)
            {
                vegetableTomato.SetActive(true);
            }
        }
        
        if (seedTreeTotalAmount > 0)
        {
            treePlaceholder.SetActive(true);

            if (seedTreeAppleAmount > 0)
            {
                treeApple.SetActive(true);
            }
            if (seedTreeCherryAmount > 0)
            {
                treeCherry.SetActive(true);
            }
        }

        if (seedHerbTotalAmount > 0)
        {
            herbPlaceholder.SetActive(true);

            if (seedHerbFychiLeafAmount > 0)
            {
                herbFychiLeaf.SetActive(true);
            }
            if (seedHerbCascadymeAmount > 0)
            {
                herbCascadyme.SetActive(true);
            }
            if (seedHerbAvialiAmount > 0)
            {
                herbAviali.SetActive(true);
            }
            if (seedHerbWinterStalkAmount > 0)
            {
                herbWinterStalk.SetActive(true);
            }
            if (seedHerbJadenWeedAmount > 0)
            {
                herbJadenWeed.SetActive(true);
            }
            if (seedHerbSeadwarfPetalAmount > 0)
            {
                herbSeadwarfPetal.SetActive(true);
            }
        }
    }
    
    public void DisableAllSeedUI()
    {
        //use lists?

        //disable all UI before checking if you have enough seeds
        fruitPlaceholder.SetActive(false);
        fruitStrawberry.SetActive(false);
        fruitBlackberry.SetActive(false);
        fruitCyennaberry.SetActive(false);

        vegetablePlaceholder.SetActive(false);
        vegetablePotato.SetActive(false);
        vegetableTomato.SetActive(false);

        treePlaceholder.SetActive(false);
        treeApple.SetActive(false);
        treeCherry.SetActive(false);

        herbPlaceholder.SetActive(false);
        herbFychiLeaf.SetActive(false);
        herbCascadyme.SetActive(false);
        herbAviali.SetActive(false);
        herbWinterStalk.SetActive(false);
        herbJadenWeed.SetActive(false);
        herbSeadwarfPetal.SetActive(false);
    }
}
