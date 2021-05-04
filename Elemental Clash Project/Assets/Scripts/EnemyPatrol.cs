using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    //public varibles
    public float forceStrength;
    public Vector2[] patrolpoints; //patrol point the enemy will move to
    public float stopDistance;

    private Rigidbody2D ourRigidbody;
    private int currentPoint = 0;


    // Awake is called when the script is loaded
    void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = (patrolpoints[currentPoint] - -(Vector2)transform.position).magnitude;
        if(distance <= stopDistance)
        {
            currentPoint = currentPoint + 1;

            if (currentPoint >= patrolpoints.Length)
            {
                currentPoint = 0;
            }
        }


        Vector2 direction = patrolpoints[currentPoint] - (Vector2)transform.position;
        direction = direction.normalized;


        ourRigidbody.AddForce(direction * forceStrength);
        
    }
}
