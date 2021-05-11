using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landscape_Script : MonoBehaviour
{
    private GameObject Player;

    public float PlayerPos;
    

    

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");

        
    }


    void Update()
    {
        PlayerPos = Player.transform.position.z;

        if(gameObject.transform.position.z - 230 >= PlayerPos)
        {
            Destroy(gameObject);
        }

    }
}
