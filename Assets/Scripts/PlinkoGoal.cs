using UnityEngine;
using UnityEngine.Events;

public class PlinkoGoal : MonoBehaviour
{
    [SerializeField] UnityEvent m_onScored;

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlinkoBall ball) && !ball.HasScored)
        {
            m_onScored.Invoke();
            ball.HasScored = true;
        }
    }
}
