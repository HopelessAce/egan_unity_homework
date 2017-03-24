using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour {

    public GameObject target;
    public float xcorrection = 1;
    public float zcorrection = 1;
    public float lerpspeed = 1;

    void Update()
    {
        Vector3 moveTarget = new Vector3((target.transform.position.x + xcorrection), transform.position.y, (target.transform.position.z + zcorrection));
        transform.position = Vector3.Lerp(transform.position, moveTarget, Time.deltaTime * lerpspeed);
    
}
}
