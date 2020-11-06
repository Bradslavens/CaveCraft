using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _characterController;
    private Vector3 _playerVelocity;
    private bool _groundedPlayer;
    private float _playerSpeed =2.0f;
    private float _jumpHeight = 1.0f;
    private float _gravityValue = -9.81f;

    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        _groundedPlayer = _characterController.isGrounded;
        if(_groundedPlayer && _playerVelocity.y < 0){
            _playerVelocity.y = 0.0f;
        }

        Vector3 _move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _characterController.Move(_move * Time.deltaTime * _playerSpeed);

        if(_move != Vector3.zero){
            gameObject.transform.forward = _move;
        }

        if(Input.GetButtonDown("Jump") && _groundedPlayer){
            _playerVelocity.y += Mathf.Sqrt(_jumpHeight * -3.0f * _gravityValue);
        }

        _playerVelocity.y += _gravityValue * Time.deltaTime;
        _characterController.Move(_playerVelocity * Time.deltaTime);
    }
}
