using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = target.position;
        Vector3 fwd = target.forward;

        transform.position = pos;
        transform.position += -fwd * 10;
        transform.position += new Vector3(0, 5, 0);

        transform.LookAt(pos);



    }
}
