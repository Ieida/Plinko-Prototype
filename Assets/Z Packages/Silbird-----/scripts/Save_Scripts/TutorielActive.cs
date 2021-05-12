using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorielActive : MonoBehaviour
{

    public static bool TutorielSeen;
    public GameObject Tutoriel;
    public GameObject Button_close;
    public GameObject Button_open;

    
    // Update is called once per frame
    void Update()
    {

        if (Button_close)
        {

            if (TutorielSeen == true)
            {
                Button_close.SetActive(false);
                Button_open.SetActive(true);
            }
            if (TutorielSeen == false)
            {
                Button_close.SetActive(true);
                Button_open.SetActive(false);
            }


            if (Button_close.activeSelf == true)
            {
                Tutoriel.SetActive(true);
            }
            if (Button_open.activeSelf == true)
            {
                Tutoriel.SetActive(false);
            }
        }
    }




    public void TutorielSeeen()
    {
        
            Button_close.SetActive(false);
            Button_open.SetActive(true);
            TutorielSeen = true;
        
    }

    public void TutorielNotSeeen()
    {
        
            Button_close.SetActive(true);
            Button_open.SetActive(false);
            TutorielSeen = false;
        
    }

    public void Destroy()
    {
        Destroy(Button_close);
        Destroy(Button_open);
    }

}
