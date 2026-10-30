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
            rb.linearVelocity = (new Vector3(speed,0,0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = (new Vector3(-speed,0,0));
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
        
    }
}
