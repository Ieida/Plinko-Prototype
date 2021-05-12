using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle_Script : MonoBehaviour
{

    private GameObject Player;
    public Score_Script Score_Script;
    public float Timer;

    private bool Switch_01;
    

    public float Distance;
    public float DistanceToDestroy;

    private BoxCollider Coll;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        Switch_01 = false;
        Coll = GetComponent<BoxCollider>();
        
    }


    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject == Player)
        {
            Score_Script.ScorePoints += 5;
            
            Switch_01 = true;
            
        }
    }


    void Update()
    {
        Distance = Vector3.Distance(Player.transform.position, gameObject.transform.position);

        if (Switch_01 == true)
        {
            Timer = Timer + 2 * Time.deltaTime;
            if(Timer >= 1.5)
            {
                Coll.enabled = false;
            }
            if (Timer >= 10)
            {
                Destroy(gameObject);
            }

        }
        if(Distance >= DistanceToDestroy)
        {
            Destroy(gameObject);
        }

    }
}
