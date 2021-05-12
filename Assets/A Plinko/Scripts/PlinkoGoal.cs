using UnityEngine;
using UnityEngine.Events;

public class PlinkoGoal : MonoBehaviour
{
    [SerializeField] UnityEvent m_onScored;

    public GameObject EndScreen;
    public PlinkoBall plinkoBall_SCript;

    void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlinkoBall ball))
        {
            m_onScored.Invoke();
            EndScreen.SetActive(true);
            //More deaktivating
            plinkoBall_SCript.enabled = false;
        }
    }
}
