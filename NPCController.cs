using UnityEngine;

public class Try : MonoBehaviour
{
    public int health = 5;
    public int level = 1;
    public float speed = 1.2f;

    void Start()
    {
    }

    void Update()
    {
        
        Vector3 newPosition;


        newPosition = transform.position;


        newPosition.z += speed * Time.deltaTime;


        transform.position = newPosition;
    }
}
