using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    // new Transform transform;
    public float speed = 10f;
    // GameObject gameObject;
    // Start is called before the first frame update
    BoxCollider boxCollider;
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        // transform = GetComponent<Transform>();
        // transform.position = new Vector3(10f, transform.position.y, transform.position.z);

        // Debug.Log(transform);
        boxCollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moviment = new Vector3(horizontal, vertical, 0f);
        transform.position += moviment * Time.deltaTime * speed;
        Debug.Log(moviment);

        // if (Input.GetKeyDown(KeyCode.D))
        // {
        //     Debug.Log("Ok");
        // }
    }



}
