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
        _cubePosition = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1);
        object p = Instantiate(_cube, _cubePosition, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
