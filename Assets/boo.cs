using UnityEngine;
using UnityEngine.UIElements;

public class boo : MonoBehaviour

{
    public float verticalAmplitude = 3.0f;    
    public float horizontalAmplitude = 3.0f;    
    public float frequency = 2.0f;    
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        
    }

    void Update()
    {
        float newY = startPosition.y + verticalAmplitude * Mathf.Sin(Time.time * frequency);
        float newX = startPosition.x + horizontalAmplitude * Mathf.Cos(Time.time * frequency);
        transform.position = new Vector3(newX, newY, startPosition.z);
    }
}