using UnityEngine;

public class Heen_en_weer : MonoBehaviour
{
    public float snelheid = 3.0f;
    public float afstand = 8.0f;

    void Update()
    {
        transform.position += Vector3.forward * snelheid * Time.deltaTime;
    }
}