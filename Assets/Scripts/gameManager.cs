using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    [SerializeField] private GameObject [] playerArray ;
    // Start is called before the first frame update
     public GameObject currentPlayer;
    void ChangePlayer()
    {
        playerArray[0] = currentPlayer;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
