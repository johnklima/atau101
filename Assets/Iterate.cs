using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iterate : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform spectrumAT;
    void Start()
    {
	foreach(Transform mychild in spectrumAT)
		Debug.Log(mychild.name);
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
