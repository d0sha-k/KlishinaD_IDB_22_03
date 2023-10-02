using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButUI2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Sphere;
    public void ButPress()
    {
        if (Sphere.active == false)
        {
            Debug.Log("Object is deactivated");

        }
        if (Sphere.active == true)
        {
            Debug.Log("Object is activated");

        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
