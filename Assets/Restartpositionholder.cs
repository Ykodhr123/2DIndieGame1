using UnityEngine;

public class Restartpositionholder : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Vector3 currentRestartPosition;
    void Start()
    {
        currentRestartPosition = transform.position;
    }

    public Vector3 GetCurrentRestartPosition()
    {
        return currentRestartPosition;
    }
}