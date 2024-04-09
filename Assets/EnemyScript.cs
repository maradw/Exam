using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private Rigidbody enemyRBD;
    float velocity = 4f;
    [SerializeField] private Transform transformEnemy;
    int direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        enemyRBD.velocity = new Vector2(velocity * 1, 0);
        /*transformEnemy.position = new Vector3(transformEnemy.position.x + velocity * direction * Time.deltaTime, 4.78f, 0);
        if (transformEnemy.position.x > 1.76f)
        {
            direction = -1;

        }
        if (transformEnemy.position.x < -2.78f)
        {
            direction = 1;

        }
        */
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
