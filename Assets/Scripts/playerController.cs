using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System;

public class playerController : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    private float _up;
    [SerializeField] private Rigidbody myRBD;
    [SerializeField] private float velocityModifier = 5f;
    [SerializeField] private float upModifier = 8f;
    public static event Action<int> OnPlayerDamaged;
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
        myRBD.velocity = new Vector3(_horizontal * velocityModifier, 0, _vertical * velocityModifier);
    }
    public void OnJump(InputAction.CallbackContext jump)
    {
        _up = jump.ReadValue<Vector3>().y;
    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //OnPlayerDamaged?.Invoke(1);
            Debug.Log("enemy");
        }
        else if (collision.gameObject.tag == "ogre")
        {
           // OnPlayerDamaged?.Invoke(2);

        }
        

    }
}