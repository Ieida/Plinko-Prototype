using UnityEngine;

public class PlinkoCamera : MonoBehaviour
{
    [SerializeField] Transform m_ball;

    void LateUpdate()
    {
        Vector3 from = transform.position.normalized;
        from.y = 0.0f;
        from.Normalize();
        Vector3 to = m_ball.position.normalized;
        to.y = 0.0f;
        to.Normalize();
        transform.RotateAround(
            Vector3.zero,
            Vector3.up,
            Vector3.SignedAngle(
                from,
                to,
                Vector3.up
            )
        );
    }
}
