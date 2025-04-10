using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
  Rigidbody rr;
    void Start()
    {
        rr = GetComponent<Rigidbody>();
                 
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKey(KeyCode.W))
        // {
        //     rr.AddForce(Vector3.forward * speed);
        // }
        // if (Input.GetKey(KeyCode.S))
        // {
        //     rr.AddForce(Vector3.back * speed);
        // }
        // if (Input.GetKey(KeyCode.A))
        // {
        //     rr.AddForce(Vector3.left * speed);
        // }
        // if (Input.GetKey(KeyCode.D))
        // {
        //     rr.AddForce(Vector3.right * speed);
        // }
        
    }
}
