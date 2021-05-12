using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Movement_Player : MonoBehaviour
{

    public Rigidbody Rb;
    private bool Switch_01 = false;
    public bool Switch_02 = false;
    public bool Switch_03 = false;
    public bool Switch_04 = false;
    public bool Switch_05 = false;
    public bool Switch_06 = false;
    public bool Switch_07 = false;
    public float Force_down;
    public float Force_front;

    public float Air_Speed_sys;
    public float Air_Speed_Modifier_sys;
    public float Grounded_Speed_sys;
    public float Grounded_Speed_Modifier_sys;
    

    public float Speed_Modifier;

    public float Speed;
    public float Distance;
    public float Switch_Distance;

    //End Screen
    public GameObject EndScreen;

    public GameObject Particals;

    public GameObject ForcePit;
    public GameObject ForcePitAnchor_02;
    public GameObject Ancor;
    public Vector3 AncorPosition;
    public GameObject UpForcePit;


    public Vector3 RaycastHitPosition;
    public Vector3 Ray_GroundPoint;
    public GameObject RayPos;
    public GameObject RayAncor;

    public Score_Script Score_Script;

    public bool IsGrounded = false;
    public float Timer = 5f;
    public float Timer_02 = 0;

    public float Ray_Lenght;

    

    public double AngularDrag = 0.0005;

    public GameObject Trails;

    public GameObject DeathEffekt_01;
    public GameObject DeathEffekt_02;

    public GameObject MiddleofPlayer;

    // Start is called before the first frame update
    void Start()
    {
        Ancor.transform.position = gameObject.transform.position;

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Switch_05 == true)
        {
            Timer_02 = Timer_02 + 2;
            Debug.Log("Lila_works");
        }

        if (Timer_02 >= 300)
        {
            if (Switch_06 == false)
            {
                EndScreen.SetActive(true);
                Switch_06 = true;
                
            }

        }



        int Mask = 1 << LayerMask.NameToLayer("Ground");
        Mask |= 1 << LayerMask.NameToLayer("Obsticles");
        RaycastHit hit;
        Ray landingRay = new Ray(RayPos.transform.position, Vector3.down);  //new pos


        if (Physics.Raycast(landingRay, out hit, 1000, Mask))
        {
            if (hit.collider.tag == "Ground")
            {

                Ray_GroundPoint = hit.point;
                //Debug.Log("Charlie_Detected");
            }
        }


        if (Input.GetMouseButton(0) && Switch_04 == false)
        {


            




            

            if (IsGrounded)
            {
                ApplyForceToReachVelocity(Rb, ForcePit.transform.forward * Force_down * Time.deltaTime, Speed_Modifier);  // VORZEICHEN BEACHTEN

            }
            else
            {
                ApplyForceToReachVelocity(Rb, -ForcePitAnchor_02.transform.up * Force_down * Time.deltaTime, Speed_Modifier);  // VORZEICHEN BEACHTEN
            }



            //ApplyForceToReachVelocity(Rb, RayAncor.transform.position * Force_down * Time.deltaTime, Speed_Modifier);
            //Rb.MovePosition(Ray_GroundPoint);
            //Rb.AddForce(RayPos.transform.position * Force_down * Time.deltaTime);

            //Rb.AddForce(-ForcePit.transform.up * Force_front * Time.deltaTime); // SEE IF YOU CAN REMOVE
        }
     

        //ApplyForceToReachVelocity(Rb, UpForcePit.transform.up * Force_front * Time.deltaTime, Speed_Modifier); // ADDJUST !!!




        

        Particals.transform.position = transform.position;

        Debug.DrawRay(transform.position, Vector3.down * Ray_Lenght);

        ForcePit.transform.LookAt(new Vector3(Ray_GroundPoint.x, Ray_GroundPoint.y, Ray_GroundPoint.z)); // Forcepit looks at rayhit Rayhit

        Distance = Vector3.Distance(gameObject.transform.position, Ancor.transform.position);
        AncorPosition = new Vector3(gameObject.transform.position.x, 0, gameObject.transform.position.z);
        Ancor.transform.position = AncorPosition;

        Speed = Rb.velocity.magnitude;

        RayPos.transform.position = new Vector3(transform.position.x, transform.position.y + 10, transform.position.z - 2);

        ForcePit.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1 / 2);

        Timer = Timer + 2 * Time.deltaTime;

        

        if (Distance >= Switch_Distance)
        {
            Switch_01 = true;
        }

        if (IsGrounded == true)
        {
            Debug.Log("Alpha_IsGrounded");

            Speed_Modifier = Grounded_Speed_Modifier_sys;
            Force_down = Grounded_Speed_sys;
        }
        else
        {
            Speed_Modifier = Air_Speed_Modifier_sys;
            Force_down = Air_Speed_sys;
        }

        

    }

    private void Update()
    {


        

        


        //If you stay grounded for longer than 8 sec. you fail.

    }

    private void OnTriggerEnter(Collider other)
    {
        if (IsGrounded == false)
        {
            if (Switch_01 == true && Timer >= 0.5f)
            {
                if (Switch_03 == false)
                {
                    Score_Script.Score_text.enabled = false;

                    Rb.angularDrag = 100000;
                    Switch_05 = true;
                    Switch_04 = true;
                    Switch_03 = true;
                    Trails.SetActive(false);
                    Instantiate(DeathEffekt_01, MiddleofPlayer.transform.position, MiddleofPlayer.transform.rotation);
                    if (Score_Script.PointsThisRound > 40)
                    {
                        Instantiate(DeathEffekt_02, MiddleofPlayer.transform.position, MiddleofPlayer.transform.rotation);
                        Switch_07 = true;
                    }
                }
                
                // !!!!! Initiate animation gamma from 0 to 255
                
                Debug.Log("Beta_Dead");
            }
        }
        else
        {
            Rb.angularDrag = 0.005f;
        }







    }

    public void UserReward()
    {
        Score_Script.Score_text.enabled = true;

        Switch_04 = false;
        EndScreen.SetActive(false);
        Switch_03 = false;
        Trails.SetActive(true);
        Switch_05 = false;
        Timer_02 = 0f;
        Switch_06 = false;
        
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject)
        {
            IsGrounded = true;
            Timer = 0;
        }
        


    }

    private void OnCollisionExit(Collision collision)
    {
        
        
            IsGrounded = false;
        
    }

    public void OnRestart()
    {
        if (Switch_07 == true)
        {
            
            Switch_07 = false;
        }
    }




    public static void ApplyForceToReachVelocity(Rigidbody rigidbody, Vector3 velocity, float force = 1, ForceMode mode = ForceMode.Force)
    {
        if (force == 0 || velocity.magnitude == 0)
            return;

        velocity = velocity + velocity.normalized * 0.2f * rigidbody.drag;

        //force = 1 => need 1 s to reach velocity (if mass is 1) => force can be max 1 / Time.fixedDeltaTime
        force = Mathf.Clamp(force, -rigidbody.mass / Time.fixedDeltaTime, rigidbody.mass / Time.fixedDeltaTime);

        //dot product is a projection from rhs to lhs with a length of result / lhs.magnitude https://www.youtube.com/watch?v=h0NJK4mEIJU
        if (rigidbody.velocity.magnitude == 0)
        {
            rigidbody.AddForce(velocity * force, mode);
        }
        else
        {
            var velocityProjectedToTarget = (velocity.normalized * Vector3.Dot(velocity, rigidbody.velocity) / velocity.magnitude);
            rigidbody.AddForce((velocity - velocityProjectedToTarget) * force, mode);
        }
    }

}
