using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    private Rigidbody rb; 
    public float parameter2 = 10; 
                                  
    void Start()
    { 
        print("This cube moves"); 
        rb = GetComponent<Rigidbody>(); 
    }

   
    void Update()
    { 
        rb.AddRelativeForce(Vector3.up * parameter2 * Input.GetAxis("Vertical")); //causes to move up when using vertical keys "up and down"
        rb.AddTorque(Vector3.left * parameter2 * Input.GetAxis("Vertical")); //causes cube to twist left when using vertical keys "up and down"
    }
}
