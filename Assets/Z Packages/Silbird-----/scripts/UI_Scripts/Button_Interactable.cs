using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Button_Interactable : MonoBehaviour
{
    
    public Button Purchase_Button_01;
    public TextMeshProUGUI Item_01_Text;
    public float ItemCost_01;
    public static bool isPurchased_01 = true;
    public static bool Item01_equipped = true;
    public GameObject Shop_Item_01;


    public Button Purchase_Button_02;
    public TextMeshProUGUI Item_02_Text;
    public float ItemCost_02;
    public static bool isPurchased_02 = false;
    public static bool Item02_equipped = false;
    public GameObject Shop_Item_02;
    

    public Button Purchase_Button_03;
    public TextMeshProUGUI Item_03_Text;
    public float ItemCost_03;
    public static bool isPurchased_03 = false;
    public static bool Item03_equipped = false;
    public GameObject Shop_Item_03;
    

    public Button Purchase_Button_04;
    public TextMeshProUGUI Item_04_Text;
    public float ItemCost_04;
    public static bool isPurchased_04 = false;
    public static bool Item04_equipped = false;
    public GameObject Shop_Item_04;
    

    public Button Purchase_Button_05;
    public TextMeshProUGUI Item_05_Text;
    public float ItemCost_05;
    public static bool isPurchased_05 = false;
    public static bool Item05_equipped = false;
    public GameObject Shop_Item_05;
    

    public Button Purchase_Button_06;
    public TextMeshProUGUI Item_06_Text;
    public float ItemCost_06;
    public static bool isPurchased_06 = false;
    public static bool Item06_equipped = false;
    public GameObject Shop_Item_06;

    public Button Purchase_Button_07;
    public TextMeshProUGUI Item_07_Text;
    public float ItemCost_07;
    public static bool isPurchased_07 = false;
    public static bool Item07_equipped = false;
    public GameObject Shop_Item_07;

    public Button Purchase_Button_08;
    public TextMeshProUGUI Item_08_Text;
    public float ItemCost_08;
    public static bool isPurchased_08 = false;
    public static bool Item08_equipped = false;
    public GameObject Shop_Item_08;
    

    public Button Purchase_Button_09;
    public TextMeshProUGUI Item_09_Text;
    public float ItemCost_09;
    public static bool isPurchased_09 = false;
    public static bool Item09_equipped = false;
    public GameObject Shop_Item_09;
    

    public Button Purchase_Button_10;
    public TextMeshProUGUI Item_10_Text;
    public float ItemCost_10;
    public static bool isPurchased_10 = false;
    public static bool Item10_equipped = false;
    public GameObject Shop_Item_10;
    

    public Button Purchase_Button_11;
    public TextMeshProUGUI Item_11_Text;
    public float ItemCost_11;
    public static bool isPurchased_11 = false;
    public static bool Item11_equipped = false;
    public GameObject Shop_Item_11;
    

    public Button Purchase_Button_12;
    public TextMeshProUGUI Item_12_Text;
    public float ItemCost_12;
    public static bool isPurchased_12 = false;
    public static bool Item12_equipped = false;
    public GameObject Shop_Item_12;
    








    public Score_Script Script_Score_Script;




    void Update()
    {





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

        if (isPurchased_04 == false)
        {
            if (ItemCost_04 > Score_Script.Money)
            {
                Purchase_Button_04.interactable = false;
                Item_04_Text.SetText("No Money");
            }
            else
            {
                Purchase_Button_04.interactable = true;
                Item_04_Text.SetText("Buy");
            }
        }

        if (isPurchased_05 == false)
        {
            if (ItemCost_05 > Score_Script.Money)
            {
                Purchase_Button_05.interactable = false;
                Item_05_Text.SetText("No Money");
            }
            else
            {
                Purchase_Button_05.interactable = true;
                Item_05_Text.SetText("Buy");
            }
        }

        if (isPurchased_06 == false)
        {
            if (ItemCost_06 > Score_Script.Money)
            {
                Purchase_Button_06.interactable = false;
                Item_06_Text.SetText("No Money");
            }
            else
            {
                Purchase_Button_06.interactable = true;
                Item_06_Text.SetText("Buy");
            }
        }

        if (isPurchased_07 == false)
        {
            if (ItemCost_07 > Score_Script.Money)
            {
                Purchase_Button_07.interactable = false;
                Item_07_Text.SetText("No Money");
            }
            else
            {
                Purchase_Button_07.interactable = true;
                Item_07_Text.SetText("Buy");
            }
        }

        if (isPurchased_08 == false)
        {
            if (ItemCost_08 > Score_Script.Money)
            {
                Purchase_Button_08.interactable = false;
                Item_08_Text.SetText("No Money");
            }
            else
            {
                Purchase_Button_08.interactable = true;
                Item_08_Text.SetText("Buy");
            }
        }

        if (isPurchased_09 == false)
        {
            if (ItemCost_09 > Score_Script.Money)
            {
                Purchase_Button_09.interactable = false;
                Item_09_Text.SetText("No Money");
            }
            else
            {
                Purchase_Button_09.interactable = true;
                Item_09_Text.SetText("Buy");
            }
        }

        if (isPurchased_10 == false)
        {
            if (ItemCost_10 > Score_Script.Money)
            {
                Purchase_Button_10.interactable = false;
                Item_10_Text.SetText("No Money");
            }
            else
            {
                Purchase_Button_10.interactable = true;
                Item_10_Text.SetText("Buy");
            }
        }

        if (isPurchased_11 == false)
        {
            if (ItemCost_11 > Score_Script.Money)
            {
                Purchase_Button_11.interactable = false;
                Item_11_Text.SetText("No Money");
            }
            else
            {
                Purchase_Button_11.interactable = true;
                Item_11_Text.SetText("Buy");
            }
        }

        if (isPurchased_12 == false)
        {
            if (ItemCost_12 > Score_Script.Money)
            {
                Purchase_Button_12.interactable = false;
                Item_12_Text.SetText("No Money");
            }
            else
            {
                Purchase_Button_12.interactable = true;
                Item_12_Text.SetText("Buy");
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

        if (isPurchased_04 == true && Item04_equipped == false)
        {
            Item_04_Text.SetText("Equip");

        }

        if (isPurchased_05 == true && Item05_equipped == false)
        {
            Item_05_Text.SetText("Equip");

        }

        if (isPurchased_06 == true && Item06_equipped == false)
        {
            Item_06_Text.SetText("Equip");

        }

        if (isPurchased_07 == true && Item07_equipped == false)
        {
            Item_07_Text.SetText("Equip");

        }

        if (isPurchased_08 == true && Item08_equipped == false)
        {
            Item_08_Text.SetText("Equip");

        }

        if (isPurchased_09 == true && Item09_equipped == false)
        {
            Item_09_Text.SetText("Equip");

        }

        if (isPurchased_10 == true && Item10_equipped == false)
        {
            Item_10_Text.SetText("Equip");

        }

        if (isPurchased_11 == true && Item11_equipped == false)
        {
            Item_11_Text.SetText("Equip");

        }

        if (isPurchased_12 == true && Item12_equipped == false)
        {
            Item_12_Text.SetText("Equip");

        }



        // Checking if Purchased and if equipped

        if (isPurchased_01 == true)
        {
            if (Item01_equipped == true)
            {
                Shop_Item_01.SetActive(true);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
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
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
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
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item_03_Text.SetText("Equipped");
            }
            else if (isPurchased_03 == true)
            {
                Item_03_Text.SetText("Equip");
            }
        }

        if (isPurchased_04 == true)
        {
            if (Item04_equipped == true)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(true);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item_04_Text.SetText("Equipped");
            }
            else if (isPurchased_04 == true)
            {
                Item_04_Text.SetText("Equip");
            }
        }

        if (isPurchased_05 == true)
        {
            if (Item05_equipped == true)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(true);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item_05_Text.SetText("Equipped");
            }
            else if (isPurchased_05 == true)
            {
                Item_05_Text.SetText("Equip");
            }
        }

        if (isPurchased_06 == true)
        {
            if (Item06_equipped == true)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(true);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item_06_Text.SetText("Equipped");
            }
            else if (isPurchased_06 == true)
            {
                Item_06_Text.SetText("Equip");
            }
        }

        if (isPurchased_07 == true)
        {
            if (Item07_equipped == true)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(true);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item_07_Text.SetText("Equipped");
            }
            else if (isPurchased_07 == true)
            {
                Item_07_Text.SetText("Equip");
            }
        }

        if (isPurchased_08 == true)
        {
            if (Item08_equipped == true)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(true);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item_08_Text.SetText("Equipped");
            }
            else if (isPurchased_08 == true)
            {
                Item_08_Text.SetText("Equip");
            }
        }

        if (isPurchased_09 == true)
        {
            if (Item09_equipped == true)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(true);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item_09_Text.SetText("Equipped");
            }
            else if (isPurchased_09 == true)
            {
                Item_09_Text.SetText("Equip");
            }
        }

        if (isPurchased_10 == true)
        {
            if (Item10_equipped == true)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(true);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item_10_Text.SetText("Equipped");
            }
            else if (isPurchased_10 == true)
            {
                Item_10_Text.SetText("Equip");
            }
        }

        if (isPurchased_11 == true)
        {
            if (Item11_equipped == true)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(true);
                Shop_Item_12.SetActive(false);
                Item_11_Text.SetText("Equipped");
            }
            else if (isPurchased_11 == true)
            {
                Item_11_Text.SetText("Equip");
            }
        }

        if (isPurchased_12 == true)
        {
            if (Item12_equipped == true)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(true);
                Item_12_Text.SetText("Equipped");
            }
            else if (isPurchased_12 == true)
            {
                Item_12_Text.SetText("Equip");
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
            if(Item01_equipped == false)
            {
                Shop_Item_01.SetActive(true);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item_01_Text.SetText("Equipped");
                Item01_equipped = true;
                Item02_equipped = false;
                Item03_equipped = false;
                Item04_equipped = false;
                Item05_equipped = false;
                Item06_equipped = false;
                Item07_equipped = false;
                Item08_equipped = false;
                Item09_equipped = false;
                Item10_equipped = false;
                Item11_equipped = false;
                Item12_equipped = false;
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
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item_02_Text.SetText("Equipped");
                Item01_equipped = false;
                Item02_equipped = true;
                Item03_equipped = false;
                Item04_equipped = false;
                Item05_equipped = false;
                Item06_equipped = false;
                Item07_equipped = false;
                Item08_equipped = false;
                Item09_equipped = false;
                Item10_equipped = false;
                Item11_equipped = false;
                Item12_equipped = false;

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
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item_03_Text.SetText("Equipped");
                Item01_equipped = false;
                Item02_equipped = false;
                Item03_equipped = true;
                Item04_equipped = false;
                Item05_equipped = false;
                Item06_equipped = false;
                Item07_equipped = false;
                Item08_equipped = false;
                Item09_equipped = false;
                Item10_equipped = false;
                Item11_equipped = false;
                Item12_equipped = false;
            }
            else if (isPurchased_03 == true)
            {
                Item_03_Text.SetText("Equip");
            }

        }

    }

    public void Gameobject04_purchase()
    {
        if (isPurchased_04 == false) // wenn gekauft is puchased
        {
            Score_Script.Money -= ItemCost_04;
            Item_04_Text.SetText("Equip");
            isPurchased_04 = true;
            return;
        }
        if (isPurchased_04 == true)
        {
            if (Item04_equipped == false)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(true);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item01_equipped = false;
                Item02_equipped = false;
                Item03_equipped = false;
                Item04_equipped = true;
                Item05_equipped = false;
                Item06_equipped = false;
                Item07_equipped = false;
                Item08_equipped = false;
                Item09_equipped = false;
                Item10_equipped = false;
                Item11_equipped = false;
                Item12_equipped = false;
                Item_04_Text.SetText("Equipped");
            }
            else if (isPurchased_04 == true)
            {
                Item_04_Text.SetText("Equip");
            }
        }

    }

    public void Gameobject05_purchase()
    {
        if (isPurchased_05 == false) // wenn gekauft is puchased
        {
            Score_Script.Money -= ItemCost_05;
            Item_05_Text.SetText("Equip");
            isPurchased_05 = true;
            return;
        }
        if (isPurchased_05 == true)
        {
            if (Item05_equipped == false)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(true);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item01_equipped = false;
                Item02_equipped = false;
                Item03_equipped = false;
                Item04_equipped = false;
                Item05_equipped = true;
                Item06_equipped = false;
                Item07_equipped = false;
                Item08_equipped = false;
                Item09_equipped = false;
                Item10_equipped = false;
                Item11_equipped = false;
                Item12_equipped = false;
                Item_05_Text.SetText("Equipped");
            }
            else if (isPurchased_05 == true)
            {
                Item_05_Text.SetText("Equip");
            }
        }

    }

    public void Gameobject06_purchase()
    {
        if (isPurchased_06 == false) // wenn gekauft is puchased
        {
            Score_Script.Money -= ItemCost_06;
            Item_06_Text.SetText("Equip");
            isPurchased_06 = true;
            return;
        }
        if (isPurchased_06 == true)
        {
            if (Item06_equipped == false)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(true);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item01_equipped = false;
                Item02_equipped = false;
                Item03_equipped = false;
                Item04_equipped = false;
                Item05_equipped = false;
                Item06_equipped = true;
                Item07_equipped = false;
                Item08_equipped = false;
                Item09_equipped = false;
                Item10_equipped = false;
                Item11_equipped = false;
                Item12_equipped = false;
                Item_06_Text.SetText("Equipped");
            }
            else if (isPurchased_06 == true)
            {
                Item_06_Text.SetText("Equip");
            }
        }

    }

    public void Gameobject07_purchase()
    {
        if (isPurchased_07 == false) // wenn gekauft is puchased
        {
            Score_Script.Money -= ItemCost_07;
            Item_07_Text.SetText("Equip");
            isPurchased_07 = true;
            return;
        }
        if (isPurchased_07 == true)
        {
            if (Item07_equipped == false)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(true);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item01_equipped = false;
                Item02_equipped = false;
                Item03_equipped = false;
                Item04_equipped = false;
                Item05_equipped = false;
                Item06_equipped = false;
                Item07_equipped = true;
                Item08_equipped = false;
                Item09_equipped = false;
                Item10_equipped = false;
                Item11_equipped = false;
                Item12_equipped = false;
                Item_07_Text.SetText("Equipped");
            }
            else if (isPurchased_07 == true)
            {
                Item_07_Text.SetText("Equip");
            }
        }

    }

    public void Gameobject08_purchase()
    {
        if (isPurchased_08 == false) // wenn gekauft is puchased
        {
            Score_Script.Money -= ItemCost_08;
            Item_08_Text.SetText("Equip");
            isPurchased_08 = true;
            return;
        }
        if (isPurchased_08 == true)
        {
            if (Item08_equipped == false)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(true);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item01_equipped = false;
                Item02_equipped = false;
                Item03_equipped = false;
                Item04_equipped = false;
                Item05_equipped = false;
                Item06_equipped = false;
                Item07_equipped = false;
                Item08_equipped = true;
                Item09_equipped = false;
                Item10_equipped = false;
                Item11_equipped = false;
                Item12_equipped = false;
                Item_08_Text.SetText("Equipped");
            }
            else if (isPurchased_08 == true)
            {
                Item_08_Text.SetText("Equip");
            }
        }

    }

    public void Gameobject09_purchase()
    {
        if (isPurchased_09 == false) // wenn gekauft is puchased
        {
            Score_Script.Money -= ItemCost_09;
            Item_09_Text.SetText("Equip");
            isPurchased_09 = true;
            return;
        }
        if (isPurchased_09 == true)
        {
            if (Item09_equipped == false)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(true);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);
                Item01_equipped = false;
                Item02_equipped = false;
                Item03_equipped = false;
                Item04_equipped = false;
                Item05_equipped = false;
                Item06_equipped = false;
                Item07_equipped = false;
                Item08_equipped = false;
                Item09_equipped = true;
                Item10_equipped = false;
                Item11_equipped = false;
                Item12_equipped = false;
                Item_09_Text.SetText("Equipped");
            }
            else if (isPurchased_09 == true)
            {
                Item_09_Text.SetText("Equip");
            }
        }

    }

    public void Gameobject10_purchase()
    {
        if (isPurchased_10 == false) // wenn gekauft is puchased
        {
            Score_Script.Money -= ItemCost_10;
            Item_10_Text.SetText("Equip");
            isPurchased_10 = true;
            return;
        }
        if (isPurchased_10 == true)
        {
            if (Item10_equipped == false)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(true);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(false);

                Item01_equipped = false;
                Item02_equipped = false;
                Item03_equipped = false;
                Item04_equipped = false;
                Item05_equipped = false;
                Item06_equipped = false;
                Item07_equipped = false;
                Item08_equipped = false;
                Item09_equipped = false;
                Item10_equipped = true;
                Item11_equipped = false;
                Item12_equipped = false;
                Item_10_Text.SetText("Equipped");
            }
            else if (isPurchased_10 == true)
            {
                Item_10_Text.SetText("Equip");
            }
        }

    }

    public void Gameobject11_purchase()
    {
        if (isPurchased_11 == false) // wenn gekauft is puchased
        {
            Score_Script.Money -= ItemCost_11;
            Item_11_Text.SetText("Equip");
            isPurchased_11 = true;
            return;
        }
        if (isPurchased_11 == true)
        {
            if (Item11_equipped == false)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(true);
                Shop_Item_12.SetActive(false);
                Item01_equipped = false;
                Item02_equipped = false;
                Item03_equipped = false;
                Item04_equipped = false;
                Item05_equipped = false;
                Item06_equipped = false;
                Item07_equipped = false;
                Item08_equipped = false;
                Item09_equipped = false;
                Item10_equipped = false;
                Item11_equipped = true;
                Item12_equipped = false;
                Item_11_Text.SetText("Equipped");
            }
            else if (isPurchased_11 == true)
            {
                Item_11_Text.SetText("Equip");
            }
        }

    }

    public void Gameobject12_purchase()
    {
        if (isPurchased_12 == false) // wenn gekauft is puchased
        {
            Score_Script.Money -= ItemCost_12;
            Item_12_Text.SetText("Equip");
            isPurchased_12 = true;
            return;
        }
        if (isPurchased_12 == true)
        {
            if (Item12_equipped == false)
            {
                Shop_Item_01.SetActive(false);
                Shop_Item_02.SetActive(false);
                Shop_Item_03.SetActive(false);
                Shop_Item_04.SetActive(false);
                Shop_Item_05.SetActive(false);
                Shop_Item_06.SetActive(false);
                Shop_Item_07.SetActive(false);
                Shop_Item_08.SetActive(false);
                Shop_Item_09.SetActive(false);
                Shop_Item_10.SetActive(false);
                Shop_Item_11.SetActive(false);
                Shop_Item_12.SetActive(true);
                Item01_equipped = false;
                Item02_equipped = false;
                Item03_equipped = false;
                Item04_equipped = false;
                Item05_equipped = false;
                Item06_equipped = false;
                Item07_equipped = false;
                Item08_equipped = false;
                Item09_equipped = false;
                Item10_equipped = false;
                Item11_equipped = false;
                Item12_equipped = true;
                Item_12_Text.SetText("Equipped");
            }
            else if (isPurchased_12 == true)
            {
                Item_12_Text.SetText("Equip");
            }
        }

    }





    public void Purchased_Reset()
    {
        isPurchased_01 = true;
        isPurchased_02 = false;
        isPurchased_03 = false;
        isPurchased_04 = false;
        isPurchased_05 = false;
        isPurchased_06 = false;
        isPurchased_07 = false;
        isPurchased_08 = false;
        isPurchased_09 = false;
        isPurchased_10 = false;
        isPurchased_11 = false;
        isPurchased_12 = false;
        Item01_equipped = true;
        Item02_equipped = false;
        Item03_equipped = false;
        Item04_equipped = false;
        Item05_equipped = false;
        Item06_equipped = false;
        Item07_equipped = false;
        Item08_equipped = false;
        Item09_equipped = false;
        Item10_equipped = false;
        Item11_equipped = false;
        Item12_equipped = false;

    }

}
