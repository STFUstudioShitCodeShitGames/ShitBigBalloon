using UnityEngine;

public class ChubaNiz : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.GetComponent<UkaZlo>())
            return;
        
        Destroy(other.gameObject);
    }
}
