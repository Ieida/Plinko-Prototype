using UnityEngine;
using UnityEngine.Events;

public class PlinkoBall : MonoBehaviour
{
    [SerializeField] float m_playerForce;
    [SerializeField] Transform m_camera;
    [SerializeField] UnityEvent m_onBallDropped;

    void Start()
    {
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(m_camera.right * Input.GetAxisRaw("Horizontal"));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            m_onBallDropped.Invoke();
        }
    }
}
