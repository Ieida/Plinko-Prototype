using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Procedual_spawning : MonoBehaviour
{

    public GameObject Prefab_A_01;
    public GameObject Prefab_A_02;

    public GameObject SpawnPos;
    public Vector3 SpawnPosVector;
    public Vector3 SecondSpawnVector;
    public float Wert;

    private bool A_01_LastSpawned = true;
    private bool A_02_LastSpawned = false;

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
        PlayerPos = Player.transform.position.z;

        SpawnPos.transform.position = SpawnPosVector;


        if (SpawnPos.transform.position.z >= PlayerPos -230)
        {
            if (A_01_LastSpawned == true)
            {
                Instantiate(Prefab_A_02, SpawnPosVector, Prefab_A_02.transform.rotation);
                Stfu();
                A_01_LastSpawned = false;
                A_02_LastSpawned = true;
                return;
            }
        }
        if (SpawnPos.transform.position.z >= PlayerPos -230)
        {
            if (A_02_LastSpawned == true)
            {

                Instantiate(Prefab_A_01, SpawnPosVector, Prefab_A_01.transform.rotation);
                Stfu();
                A_02_LastSpawned = false;
                A_01_LastSpawned = true;
            }
        }


    }


    void Stfu()
    {
        SpawnPosVector = SpawnPosVector + SecondSpawnVector;
    }

}
