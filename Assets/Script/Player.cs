using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    List<GameObject> playersPrefab = new List<GameObject>();
    new Rigidbody rigidbody;
    public float velocidade = 10f;
    public float forcaPulo = 10f;
    public bool pulo;
    



    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(50 * Time.deltaTime, 0, 0);
        MovimentacaoPlayer();
        Pulo();

    }
    void MovimentacaoPlayer()
    {
        float horizontal = Input.GetAxis("Horizontal") * velocidade * Time.deltaTime;
        // float vertical = Input.GetAxis("Vertical") * velocidade * Time.deltaTime;
        // velocidade = velocidade * Time.deltaTime;

        if (rigidbody.velocity.magnitude <= 3f)
            // rigidbody.velocity = new Vector3(horizontal, 0f, 0f);
            rigidbody.AddForce(new Vector3(horizontal, 0f, 0f));
        // rigidbody.AddForce(new Vector3(velocidade, 0f, 0f));

    }

    void Pulo()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !pulo)
        {
            rigidbody.AddForce(new Vector3(0f, forcaPulo), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 6) pulo = false;
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.layer == 6) pulo = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Color"))
        {
            GetComponent<Renderer>().material.color = other.GetComponent<Renderer>().material.color;
        }
    }

    void CreateFirstPlyaer(int Index)
    {
        Instantiate(playersPrefab[Index], new Vector3(-9.2f, 1.76015f, 0.4601035f), Quaternion.identity);
    }

    
}
