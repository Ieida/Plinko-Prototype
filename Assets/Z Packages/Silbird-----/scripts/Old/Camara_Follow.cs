using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara_Follow : MonoBehaviour
{

    public GameObject Camera;
    public GameObject Anchor_01;
    public GameObject Player;

    private Vector3 Anchor_position;
    private Vector3 Player_position;

    public float Offset_x;
    public float Offset_y;
    public float Offset_z;

    public Animator CameraToBall;


    void Start()
    {
        CameraToBall.Play("CameraToBall");
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Player_position = Player.transform.position;

        
        Camera.transform.position = Anchor_01.transform.position;
        Anchor_01.transform.position = new Vector3(Player.transform.position.x + Offset_x, Player.transform.position.y + Offset_y, Player.transform.position.z + Offset_z);


    }
}
