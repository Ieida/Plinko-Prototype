using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SwapLandscapes : MonoBehaviour
{
    
    public Button Purchase_Button_01;
    public float ItemCost_01;
    public static bool isPurchased_01 = true;
    public static bool Item01_equipped = true;
    public GameObject Shop_Item_01;
    public TextMeshProUGUI Item_01_Text;

    public Button Purchase_Button_02;
    public float ItemCost_02;
    public static bool isPurchased_02 = false;
    public static bool Item02_equipped = false;
    public GameObject Shop_Item_02;
    public TextMeshProUGUI Item_02_Text;

    public Button Purchase_Button_03;
    public float ItemCost_03;
    public static bool isPurchased_03 = false;
    public static bool Item03_equipped = false;
    public GameObject Shop_Item_03;
    public TextMeshProUGUI Item_03_Text;

    public GameObject ForestScriptManager;
    public GameObject DesertScriptManager;
    public GameObject SnowScriptManager;

    public GameObject Forest_01;
    public GameObject ForestShop;

    public GameObject Desert_01;
    public GameObject DesertShop;

    public GameObject Snow_01;
    public GameObject SnowShop;


    public Score_Script Script_Score_Script;

    public bool GameStarted = false;



    public void GameHasStarted()
    {
        GameStarted = true;
    }


    void Update()
    {

        if (GameStarted == true) // could add switch
        {
            if (Item01_equipped == true)
            {
                ForestScriptManager.SetActive(true);
                
            }

            if (Item02_equipped == true)
            {
                DesertScriptManager.SetActive(true);
                
            }



            if (Item03_equipped == true)
            {
                SnowScriptManager.SetActive(true);
                
            }

        }

        




        // If not purchased

        if (isPurchased_01 == false)
        {
            if (ItemCost_01 > Score_Script.Money)
            {
                Purchase_Button_01.interactable = false;
                Item_01_Text.SetText("No Money");
            }
            else
            {
                Purchase_Button_01.interactable = true;
                Item_01_Text.SetText("Buy");
            }
        }

        if (isPurchased_02 == false)
        {
            if (ItemCost_02 > Score_Script.Money)
            {
                Purchase_Button_02.interactable = false;
                Item_02_Text.SetText("No Money");
            }
            else
            {
                Purchase_Button_02.interactable = true;
                Item_02_Text.SetText("Buy");
            }
        }

        if (isPurchased_03 == false)
        {
            if (ItemCost_03 > Score_Script.Money)
            {
                Purchase_Button_03.interactable = false;
                Item_03_Text.SetText("No Money");
            }
            else
            {
                Purchase_Button_03.interactable = true;
                Item_03_Text.SetText("Buy");
            }
        }








        // If Puchased but not equipped

        if (isPurchased_01 == true && Item01_equipped == false)
        {
            Item_01_Text.SetText("Equip");

        }

        if (isPurchased_02 == true && Item02_equipped == false)
        {
            Item_02_Text.SetText("Equip");

        }

        if (isPurchased_03 == true && Item03_equipped == false)
        {
            Item_03_Text.SetText("Equip");

        }

  



        // Checking if Purchased and if equipped

        if (isPurchased_01 == true)
        {
            if (Item01_equipped == true)
            {
                Shop_Item_01.SetActive(true);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);

                ForestShop.SetActive(true);
                DesertShop.SetActive(false);
                SnowShop.SetActive(false);

                Item_01_Text.SetText("Equipped");
            }
            else if (isPurchased_01 == true)
            {
                Item_01_Text.SetText("Equip");
            }
        }

        if (isPurchased_02 == true)
        {
            if (Item02_equipped == true)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(true);
                Shop_Item_03.SetActive(false);
                ForestShop.SetActive(false);
                DesertShop.SetActive(true);
                SnowShop.SetActive(false);

                Item_02_Text.SetText("Equipped");
            }
            else if (isPurchased_02 == true)
            {
                Item_02_Text.SetText("Equip");
            }
        }

        if (isPurchased_03 == true)
        {
            if (Item03_equipped == true)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(true);
                ForestShop.SetActive(false);
                DesertShop.SetActive(false);
                SnowShop.SetActive(true);

                Item_03_Text.SetText("Equipped");
            }
            else if (isPurchased_03 == true)
            {
                Item_03_Text.SetText("Equip");
            }
        }




    }



    // Buying and equipping

    public void Gameobject01_purchase()
    {
        if (isPurchased_01 == false) // wenn gekauft is puchased
        {
            Score_Script.Money -= ItemCost_01;
            Item_01_Text.SetText("Equip");
            isPurchased_01 = true;
            return;
        }
        if(isPurchased_01 == true)
        {
            if (Item01_equipped == false)
            {
                Shop_Item_01.SetActive(true);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);

                Item_01_Text.SetText("Equipped");
                Item01_equipped = true;
                Item02_equipped = false;
                Item03_equipped = false;
                /*
                ForestScriptManager.SetActive(true);
                DesertScriptManager.SetActive(false);
                SnowScriptManager.SetActive(false);
                */
                Forest_01.SetActive(true);
                Desert_01.SetActive(false);
                Snow_01.SetActive(false);
                ForestShop.SetActive(true);
                DesertShop.SetActive(false);
                SnowShop.SetActive(false);
            }
            else if(isPurchased_01 == true)
            {
                Item_01_Text.SetText("Equip");
            }
        }

    }

    public void Gameobject02_purchase()
    {
        if (isPurchased_02 == false) // wenn gekauft is puchased
        {
            Score_Script.Money -= ItemCost_02;
            Item_02_Text.SetText("Equip");
            isPurchased_02 = true;
            return;
        }
        if (isPurchased_02 == true)
        {
            if (Item02_equipped == false)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(true);
                Shop_Item_03.SetActive(false);

                Item_02_Text.SetText("Equipped");
                Item01_equipped = false;
                Item02_equipped = true;
                Item03_equipped = false;
                /*
                ForestScriptManager.SetActive(false);
                DesertScriptManager.SetActive(true);
                SnowScriptManager.SetActive(false);
                */
                Forest_01.SetActive(false);
                Desert_01.SetActive(true);
                Snow_01.SetActive(false);
                ForestShop.SetActive(false);
                DesertShop.SetActive(true);
                SnowShop.SetActive(false);

            }
            else if (isPurchased_02 == true)
            {
                Item_02_Text.SetText("Equip");
            }
        }

    }

    public void Gameobject03_purchase()
    {
        if (isPurchased_03 == false) // wenn gekauft is puchased
        {
            Score_Script.Money -= ItemCost_03;
            Item_03_Text.SetText("Equip");
            isPurchased_03 = true;
            return;
        }
        if (isPurchased_03 == true)
        {
            if (Item03_equipped == false)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(true);

                Item_03_Text.SetText("Equipped");
                Item01_equipped = false;
                Item02_equipped = false;
                Item03_equipped = true;
                /*
                ForestScriptManager.SetActive(false);
                DesertScriptManager.SetActive(false);
                SnowScriptManager.SetActive(true);
                */
                Forest_01.SetActive(false);
                Desert_01.SetActive(false);
                Snow_01.SetActive(true);
                ForestShop.SetActive(false);
                DesertShop.SetActive(false);
                SnowShop.SetActive(true);
            }
            else if (isPurchased_03 == true)
            {
                Item_03_Text.SetText("Equip");
            }

        }

    }

  





    public void Purchased_Reset()
    {
        isPurchased_01 = true;
        isPurchased_02 = false;
        isPurchased_03 = false;

        Item01_equipped = true;
        Item02_equipped = false;
        Item03_equipped = false;


    }

}
