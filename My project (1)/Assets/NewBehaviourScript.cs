using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class NewBehaviourScript : MonoBehaviour
{
    public Text countrtxt;
    public hw2_script Cubescript;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        countrtxt.text = "score: " + Cubescript.score;
    }
}
