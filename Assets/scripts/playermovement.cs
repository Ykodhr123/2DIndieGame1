using UnityEngine;

public class playermovement : MonoBehaviour
{///Handles movement without the use of a Rigidbody
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private float movementspeed;
    [SerializeField]private float Jumpforce;

    private Rigidbody2D rb;
    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(movementspeed * Time.deltaTime, transform.position.z, transform.position.z);

        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-(movementspeed * Time.deltaTime), transform.position.z, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, Jumpforce));
        }
        
    }
}
