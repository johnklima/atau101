using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public float spinRate = 1;
    public float moveSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float rot = Input.GetAxis("Horizontal");
        float move = Input.GetAxis("Vertical");

        transform.Rotate(new Vector3(0, rot, 0) * Time.deltaTime * spinRate);
        transform.Translate(transform.forward * move * Time.deltaTime * moveSpeed, Space.World);
    }
}
