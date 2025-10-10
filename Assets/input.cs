using UnityEngine;

public class input : MonoBehaviour
{

    public float moveSpeed = 25f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    // Update is called once per frame
    public void Update()
    {



    Vector3 newPosition = transform.position;
        

        if (Input.GetKey(KeyCode.A))
        {
            newPosition.x -= moveSpeed * Time.deltaTime;
            transform.position = newPosition;
        }

        if (Input.GetKey(KeyCode.D))
        {
            newPosition.x += moveSpeed * Time.deltaTime;
            transform.position = newPosition;
        }

        if (Input.GetKey(KeyCode.W))
        {
            newPosition.z += moveSpeed * Time.deltaTime;
            transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newPosition.z -= moveSpeed * Time.deltaTime;
            transform.position = newPosition;
        }
    }
}