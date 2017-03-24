using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {

    public Rigidbody rb;
    public float hoverforce = 100;
    public float forwardforce = 2;
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	
	void FixedUpdate ()
    {
        Vector3 forward = transform.TransformDirection(Vector3.up * -1) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);

        RaycastHit hit;

        Ray ray = new Ray(transform.position, transform.up * -1);

        if (Physics.Raycast(ray, out hit))
        {
            print(hit.distance);
            rb.AddRelativeForce(Vector3.up * hoverforce/Mathf.Exp(hit.distance));
        }

        rb.AddRelativeTorque(Vector3.up * hoverforce * Input.GetAxis("Horizontal"));
        rb.AddRelativeTorque(Vector3.left * forwardforce * Input.GetAxis("Vertical"));
	}
}
