using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> playersPrefab = new List<GameObject>();

    public int indexPlayer = 0;
    GameObject playerCreate;

    Vector3 posicaoPlayer;
    void Awake()
    {
        // CreateFirstPlyaer(indexPlayer);
    }

    // Start is called before the first frame update
    void Start()
    {
        playerCreate = CreateFirstPlyaer(indexPlayer);
    }

    // Update is called once per frame
    void Update()
    {
        ChangePlayer();
    }

    public void ChangePlayer()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            indexPlayer = 0;
            _Instantiate(indexPlayer);


        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            indexPlayer = 1;
            _Instantiate(indexPlayer);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            indexPlayer = 2;
            _Instantiate(indexPlayer);
        }
        else if (Input.GetKeyDown(KeyCode.V))
        {
            Debug.Log("v");
        }
    }

    void _Instantiate(int Index)
    {

        // posicaoPlayer = playerCreate.transform;
        posicaoPlayer = new Vector3(playerCreate.transform.position.x, playerCreate.transform.position.y, playerCreate.transform.position.z);

        Destroy(playerCreate);

        if (Index == 2)
        {
            posicaoPlayer.y = 3f;
            posicaoPlayer.z = 0.5f;
        }

        playerCreate = Instantiate(playersPrefab[Index], posicaoPlayer, Quaternion.identity);
        // playerCreate = Instantiate(playersPrefab[Index], new Vector3(posicaoPlayer.position.x, posicaoPlayer.position.y, posicaoPlayer.position.z), Quaternion.identity);
    }

    private GameObject CreateFirstPlyaer(int Index)
    {
        return Instantiate(playersPrefab[Index], new Vector3(-9.2f, 1.76015f, 0.4601035f), Quaternion.identity);

    }

}


