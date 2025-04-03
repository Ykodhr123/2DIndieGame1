using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public float fallThreshold = -10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < fallThreshold)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
