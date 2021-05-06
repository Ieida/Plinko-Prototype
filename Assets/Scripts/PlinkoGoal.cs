using UnityEngine;
using UnityEngine.Events;

public class PlinkoGoal : MonoBehaviour
{
    [SerializeField] UnityEvent m_onScored;

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlinkoBall ball))
        {
            m_onScored.Invoke();
            Destroy(other.gameObject);
        }
    }
}
