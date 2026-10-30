using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public int speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            /*rb.linearVelocity = (new Vector3(speed,0,0));*/
            rb.AddForce(-Vector3.left * speed, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed, ForceMode.Acceleration);
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
        
    }
}
