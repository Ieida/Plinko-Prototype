using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidelaneProcedual_spawning : MonoBehaviour
{

    public GameObject Prefab_01;
    public GameObject Prefab_02;
    public GameObject Prefab_03;
    public GameObject Prefab_04;
    public GameObject Prefab_05;
    public GameObject Prefab_06;


    public GameObject SpawnPos;
    public Vector3 SpawnPosVector;
    public Vector3 SecondSpawnVector;
    public float Wert;

    public int MaxRandomNum;


    public GameObject Player;
    public float PlayerPos;


    public Quaternion Origin_rotation_A_02;
    public Landscape_Script Landscape_Script;
    
    void Start()
    {
        
        Player = GameObject.FindGameObjectWithTag("Player");

    }

    
    void Update()
    {

        int randomNum = Random.Range(1, MaxRandomNum);

        PlayerPos = Player.transform.position.z;

        SpawnPos.transform.position = SpawnPosVector;

        if (SpawnPos.transform.position.z >= PlayerPos - 250)
        {
            if (randomNum == 17)
            {
                Instantiate(Prefab_06, SpawnPosVector, Prefab_06.transform.rotation);
                Stfu();
                Debug.Log("November_Works_06");
                return;
                
            }
        
            if (randomNum == 16)
            {
                Instantiate(Prefab_05, SpawnPosVector, Prefab_05.transform.rotation);
                Stfu();
                Debug.Log("November_Works_05");
                return;
            }
      
            if (randomNum == 15)
            {
                Instantiate(Prefab_04, SpawnPosVector, Prefab_04.transform.rotation);
                Stfu();
                Debug.Log("November_Works_04");
                return;
            }
       
            if (randomNum == 14)
            {
                Instantiate(Prefab_03, SpawnPosVector, Prefab_03.transform.rotation);
                Stfu();
                Debug.Log("November_Works_03");
                return;
            }
       
            if (randomNum == 13)
            {
                Instantiate(Prefab_02, SpawnPosVector, Prefab_02.transform.rotation);
                Stfu();
                Debug.Log("November_Works_02");
                return;
            }
        
            if (randomNum <= 12 && randomNum >= 0)
            {

                Instantiate(Prefab_01, SpawnPosVector, Prefab_01.transform.rotation);
                Stfu();
                Debug.Log("November_Works_01");
                return;
            }
        }


    }


    void Stfu()
    {
        SpawnPosVector = SpawnPosVector + SecondSpawnVector;
    }

}
