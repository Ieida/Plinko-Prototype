using UnityEngine;

public class PlinkoBall : MonoBehaviour
{
    [SerializeField] float m_playerForce;
    public bool HasScored { get; set; }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(
            Input.GetAxisRaw("Horizontal") * m_playerForce,
            0.0f,
            0.0f
        );
    }
}
