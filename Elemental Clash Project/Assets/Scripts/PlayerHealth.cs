using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //player starting health
    public int startingHealth;

    private int currentHealth;// keeps track of players current health
    //bulit in function called when the script is created 
    //and will change as the game gose on
    void Awake()
    {

        //Initialise our current health to be equal to our starting health as equal at the start of the game
        currentHealth = startingHealth;
    }
    // this will change player health and kill them
    // if they have less than 0
    public void ChangeHealth(int changeAmount)
    {
        Debug.Log("Change health " + changeAmount);

        //Take our current health add the change amount and store
        // the result back in the current health variable 
        currentHealth = currentHealth + changeAmount;
        //keeps our current value between 0 and starting health
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);
        // should die if health drops to 0

        if (currentHealth == 0)
        {



            Kill();
        }
    }

    // this is function is not part of unity
    // it will only be called manually by our code
    // it must be marked public so our other scripts can access it
   public void Kill()
    {
        // this will destroy the game object that this script is attached to

        Destroy(gameObject);

    }

    // This simple function will let other scripts ask this one what the current health is
    // the function RETURNS an integer, meaning it gives a number back to the code that called it
    public int GetHealth()
    {
        return currentHealth;
    }


    // This simple function will let other scripts ask this one what the max health is
    // the function RETURNS an integer, meaning it gives a number back to the code that called it
    public int GetMaxHealth()
    {
        return startingHealth;
    }

}
