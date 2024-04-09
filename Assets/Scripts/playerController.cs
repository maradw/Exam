using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    private float _up;
    [SerializeField] private Rigidbody myRBD;
    [SerializeField] private float velocityModifier = 5f;
    [SerializeField] private float upModifier = 8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnMovement(InputAction.CallbackContext move)
    {
        _horizontal = move.ReadValue<Vector3>().x;
        _vertical = move.ReadValue<Vector3>().z;
       
    }
    public void FixedUpdate()
    {
        myRBD.velocity = new Vector3(_horizontal * velocityModifier,0 , _vertical * velocityModifier);
    }
    public void OnJump(InputAction.CallbackContext jump)
    {
        _up = jump.ReadValue<Vector3>().y;
    }
    void Update()
    {
        
    }
}
