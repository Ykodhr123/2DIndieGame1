using UnityEngine;

public class collisionrestart : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Restartpositionholder restartPositionholder = collision.GetComponent<Restartpositionholder>();
            collision.gameObject.transform.position = restartPositionholder.GetCurrentRestartPosition();
        }

    }
}
