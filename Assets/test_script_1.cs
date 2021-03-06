using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_script_1 : MonoBehaviour {

    private Rigidbody rb; 
    public float parameter2 = 10;
    private Renderer rend;

    void Start () { 
        print("This boulder moves"); 
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
    }
	
	
	void Update () { 
        rb.AddRelativeForce(Vector3.up * parameter2 * Input.GetAxis("Vertical")); 
		rb.AddTorque(Vector3.left * parameter2 * Input.GetAxis("Vertical"));
        if (Input.GetButtonDown("Fire1"))
        {
            Color color = Random.ColorHSV();
            rend.material.SetColor("_Color", color);
        } 
        }
}
