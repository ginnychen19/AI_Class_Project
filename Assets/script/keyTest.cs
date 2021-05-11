using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTest : MonoBehaviour
{

    public Vector3 editR;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("s"))
        {
            transform.Translate(0,0,-0.05f);
        }
       if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, 0.05f);
        }
       if (Input.GetKey("a"))
        {
            transform.Translate(-0.05f, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            transform.Translate(0.05f, 0, 0);
        }
        if (Input.GetKey("down"))
        {
            transform.Rotate(0 , 0, 0.5f);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -0.5f, 0);
        }
        if (Input.GetKey("up"))
        {
            transform.Rotate(0, 0, -0.5f);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 0.5f, 0);
        }
    }
}
