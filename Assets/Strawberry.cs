using UnityEngine;

public class Strawberry : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Animator animator;
    private bool isCollected;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        animator = GetComponent<Animator>();
        isCollected = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && isCollected == false)
        {
            isCollected = true;
            animator.SetBool("isCollected", true);
            Destroy(this.gameObject, 0.6f);


        }
    }
}