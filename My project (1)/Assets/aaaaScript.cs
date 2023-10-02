using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaaaScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ggg;



    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Object is activated");
            ggg.SetActive(true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Object is deactivated");
            ggg.SetActive(false);
        }
    }
}
