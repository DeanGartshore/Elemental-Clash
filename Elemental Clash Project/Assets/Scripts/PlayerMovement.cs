using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // public varible visible in unity
    public float forceStrenght;

    // theses functions will be called upon by each button for movement
   public void MoveRight()
    {
        // get rigidbody for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // move in right dirction
        ourRigidbody.AddForce(Vector2.right * forceStrenght);

    }



   public void MoveLeft()
    {
        // get rigidbody for movement
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // move in right dirction
        ourRigidbody.AddForce(Vector2.left * forceStrenght);


    }


}
