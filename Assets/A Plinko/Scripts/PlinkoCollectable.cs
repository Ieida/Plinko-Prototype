using UnityEngine;
using UnityEngine.Events;

public class PlinkoCollectable : MonoBehaviour
{
    public UnityEvent onCollected;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            onCollected.Invoke();
    }
}
