using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Color : MonoBehaviour
{
    public Material[] material;
    Renderer rend;

    public static float ColorNumber;


    void Update()
    {
        if (ColorNumber == 0)
        {
            ChangetoColor00();
        }
        if (ColorNumber == 1)
        {
            ChangetoColor01();
        }
        if (ColorNumber == 2)
        {
            ChangetoColor02();
        }
        if (ColorNumber == 3)
        {
            ChangetoColor03();
        }
        if (ColorNumber == 4)
        {
            ChangetoColor04();
        }
        if (ColorNumber == 5)
        {
            ChangetoColor05();
        }
        if (ColorNumber == 6)
        {
            ChangetoColor06();
        }
        if (ColorNumber == 7)
        {
            ChangetoColor07();
        }
        if (ColorNumber == 8)
        {
            ChangetoColor08();
        }
        if (ColorNumber == 9)
        {
            ChangetoColor09();
        }
        if (ColorNumber == 10)
        {
            ChangetoColor10();
        }
        if (ColorNumber == 11)
        {
            ChangetoColor11();
        }


    }


    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = material[0];
    }



    public void ChangetoColor00()
    {
        rend.sharedMaterial = material[0];
        ColorNumber = 0;
    }

    public void ChangetoColor01()
    {
        rend.sharedMaterial = material[1];
        ColorNumber = 1;
    }

    public void ChangetoColor02()
    {
        rend.sharedMaterial = material[2];
        ColorNumber = 2;
    }

    public void ChangetoColor03()
    {
        rend.sharedMaterial = material[3];
        ColorNumber = 3;
    }

    public void ChangetoColor04()
    {
        rend.sharedMaterial = material[4];
        ColorNumber = 4;
    }

    public void ChangetoColor05()
    {
        rend.sharedMaterial = material[5];
        ColorNumber = 5;
    }

    public void ChangetoColor06()
    {
        rend.sharedMaterial = material[6];
        ColorNumber = 6;
    }

    public void ChangetoColor07()
    {
        rend.sharedMaterial = material[7];
        ColorNumber = 7;
    }

    public void ChangetoColor08()
    {
        rend.sharedMaterial = material[8];
        ColorNumber = 8;
    }

    public void ChangetoColor09()
    {
        rend.sharedMaterial = material[9];
        ColorNumber = 9;
    }

    public void ChangetoColor10()
    {
        rend.sharedMaterial = material[10];
        ColorNumber = 10;
    }
    public void ChangetoColor11()
    {
        rend.sharedMaterial = material[11];
        ColorNumber = 11;
    }


}
