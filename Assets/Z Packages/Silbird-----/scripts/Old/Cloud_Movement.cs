using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud_Movement : MonoBehaviour
{

    public float Amount;

    public GameObject Cloud;
    
    // Start is called before the first frame update
    void Start()
    {
       
        
        
    }

    // Update is called once per frame
    void Update()
    {

        Cloud.transform.position = Cloud.transform.position + new Vector3(0, 0, Amount);

    }
}