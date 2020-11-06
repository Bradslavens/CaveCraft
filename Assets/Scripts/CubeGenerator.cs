using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float _perlinNoise = 0f;
    [SerializeField] private float _refinement = 0f;
    [SerializeField] private float _multiplier = 0f;
    [SerializeField] private int _cubes = 0;

    [Header("Other")]
    [SerializeField] private GameObject _cube;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < _cubes; i++){
            for(int j = 0; j < _cubes; j++){
                _perlinNoise = Mathf.PerlinNoise(i * _refinement, j * _refinement);
                Instantiate(_cube, new Vector3(i, _perlinNoise * _multiplier, j), Quaternion.identity);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
