using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.CompareTag("Enemy") == true)
        {

            KillEnemy(otherCollider.gameObject);

        }
    }
    public void KillEnemy(GameObject enemy)
    {


        Destroy(enemy);









    }
}
