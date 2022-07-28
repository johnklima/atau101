using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IterateSpectrumObjects : MonoBehaviour
{

   

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform childT in transform)
            Debug.Log(childT.name);
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
