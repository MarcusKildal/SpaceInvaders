using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerHealth;

public class BulletHP : MonoBehaviour
{
    //variabel
    public float speed;
    public Rigidbody2D body;
    public int GiveHPToPlayer = 10;


    // Start skjer før første frame og dette bestemmer hvilken vei å hastigheten 
    void Start()
    {
        body.velocity = transform.right * (speed * 1);
    }


    //hvis bullet blir triggra med box colliederen fraunity vil den skjekke hvis noe har tag "giveHealth" så vil den kjøre player hp instance som skjer i player hp script så blir object ødlagt.
    public void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.CompareTag("GiveHealth"))
        {
            PlayerHP.Instance.GiveHealth(GiveHPToPlayer);
        }
        Destroy(gameObject);
    }
}
