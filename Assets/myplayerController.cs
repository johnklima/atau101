using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myplayerController : MonoBehaviour
{
	public float myspinRate = 40;   //this init value will be overridden by the GUI setting 
	public float mymoveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     float myrot = Input.GetAxis("Horizontal");   // between -1 and 1
        float mymove = Input.GetAxis("Vertical");
        
        transform.Rotate(new Vector3(0,myrot,0) * Time.deltaTime * myspinRate );
        transform.Translate(transform.forward * mymove * Time.deltaTime * mymoveSpeed);
     
    }
}
