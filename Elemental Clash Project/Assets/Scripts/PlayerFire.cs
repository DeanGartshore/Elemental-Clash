using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject projectitlePrefab;
    public Vector2 projectileVelocity;


    public void FireProjectitle() 
    {


        GameObject clonedProjectitle;

        clonedProjectitle = Instantiate(projectitlePrefab);

        clonedProjectitle.transform.position = transform.position;

        Rigidbody2D projectitleRigidbody;

        projectitleRigidbody = clonedProjectitle.GetComponent<Rigidbody2D>();

        projectitleRigidbody.velocity = projectileVelocity;




    }
}
