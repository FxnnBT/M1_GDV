using UnityEngine;

public class Getkeyscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        float speed = 40.0f;
        if (Input.GetKey(KeyCode.A))
        {
            newPosition.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            newPosition.x += speed * Time.deltaTime;
        }
        {
            Debug.Log("Space is pressed");
        }
    }
}
