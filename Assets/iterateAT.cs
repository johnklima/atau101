using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iterateAT : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
	foreach(Transform mychild in transform)
		Debug.Log(mychild.name);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
