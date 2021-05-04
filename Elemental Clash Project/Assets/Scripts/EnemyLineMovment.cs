using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLineMovment : MonoBehaviour
{
    public float forceStrength; // how hard the script pushes the enemy

    public Vector2 direction; // direction of movement

    private Rigidbody2D ourRigidbody; // the container of the rigidboady


    private void Awake()
    {
        ourRigidbody = GetComponent<Rigidbody2D>();

        direction = direction.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        ourRigidbody.AddForce(direction * forceStrength);
    }
}
