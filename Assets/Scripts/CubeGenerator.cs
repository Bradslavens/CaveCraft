using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{

    [SerializeField] private GameObject _cube;
    private Vector3 _cubePosition;

    // Start is called before the first frame update
    void Start()
    {
        for(int x = -10; x <= 10; x++){   
            for(int z = -10; z <= 10; z++){
                float y = Random.Range(0f, 3f);
                Instantiate(_cube, new Vector3(x,y,z), Quaternion.identity);
            }    
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
