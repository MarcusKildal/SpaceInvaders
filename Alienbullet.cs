using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerHealth;

public class Alienbullet : MonoBehaviour
{
    //variabel
    public float speed;
    public int damage = 10;
    public Rigidbody2D body;




    // hvordan bulleten kjører fins ikke down derfor er det transform.up men gjør speed -1
    void Start()
    {
        body.velocity = transform.up * (speed * -1);
    }


    //skjekker hvis bullet er triggerd ut fører den skade eller bare ødleger en object eller 
    void OnTriggerEnter2D(Collider2D hitCheck)
    {
        Earth earth = hitCheck.GetComponent<Earth>();
        if (earth != null)
        {
            Score.myScore += -10;
            earth.TakeDamage(damage);
        }


        if(hitCheck.CompareTag("Player"))
        {
            Score.myScore += -10;
            PlayerHP.Instance.TakeDamage(damage);
        }


        Score.myScore += 10;
        Destroy(gameObject);
    }

}
