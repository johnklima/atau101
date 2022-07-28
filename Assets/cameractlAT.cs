using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameractlAT : MonoBehaviour
{
	public Transform mytarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 pos = mytarget.position;
      Vector3 fwd = mytarget.forward;
      
      transform.position = pos;
      transform.position += -fwd * 10;
      transform.position += new Vector3(0, 5, 0);
      
      transform.LookAt(pos);
    }
}
