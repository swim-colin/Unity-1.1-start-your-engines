using UnityEngine;

public class PlyerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    
    public float speed = 20;

    void Update()
    {
       // Move the Vehicle forward 
       transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
