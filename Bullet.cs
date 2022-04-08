using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    //variabel hastigehet å sier hva ridig body er
    public float speed;
    public Rigidbody2D body;


    // hvordan bulleten kjører
    void Start()
    {
        body.velocity = transform.up * speed;
    }


    //blir altid ødlagt hvis den registrer at noe er oppå bullet
    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        Destroy(gameObject);
    }

}
