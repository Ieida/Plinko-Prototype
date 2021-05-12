using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Rigidbody Rb;
    public GameObject RayPos;
    public float RayLenght;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void Update()
    {



        Rb.AddForce(RayPos.transform.position * 100);
        

        RaycastHit hit;
        Ray landingRay = new Ray(RayPos.transform.position, Vector3.down);  //new pos


        if (Physics.Raycast(landingRay, out hit, RayLenght))
        {
            if (hit.collider.tag == "Ground")
            {
                
                Debug.Log("Charlie_Detected");
            }
        }





    }
}
