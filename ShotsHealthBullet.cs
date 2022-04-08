using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShotsHealthBullet : MonoBehaviour
{
    //variabel
    public Transform Firepoint;
    public GameObject Bullets;
    float timer = 0;


    //spillet er 50 frames i sekunde så 1000 frames = 20 sekunder son funker min fixed update shot void start er bare første gangen 
    void Start()
    {
        timer = Random.Range(1000,1500);
    }


    //skyter etter så så lenge etter se kommenetar over
    void FixedUpdate()
    {


        timer--;
        if (timer <= 0){
            Shoot();
            timer = Random.Range(1000,1500);

        }

    }


    //skyte funskjonen
    void Shoot(){
        Instantiate(Bullets, Firepoint.position, Firepoint.rotation);
    }
}

