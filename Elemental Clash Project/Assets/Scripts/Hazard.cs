using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    // the amount of damage the hazard dose
    public int hazardDamage;










    //Built-in function
    // this function will be called when an other object bumbs into the one this 
    // script is attached to
    void OnTriggerEnter2D(Collider2D collisionData)
    {
        // get the object we collid with
        Collider2D objectWeCollidedWith = collisionData;

        // get the player script attached to that object( if there is one)
        PlayerHealth player = objectWeCollidedWith.GetComponent<PlayerHealth>();

         //check if we actually found a player health script on the object we collided with
         //this statment is ture if the player variable is NOT null (aka empty)
        if (player != null)
        {

            player.ChangeHealth(-hazardDamage);
            
        }

    }


}
