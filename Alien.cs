using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    //variabeler
    public Transform Firepoint;
    public GameObject Bullets;
    public int MaxChanceOfShooting = 0;
    float timer = 0;

    //spillet er 50 frames i sekunde så 150 frames = 3 sekunder son funker min fixed update shot void start er bare første gangen 
    void Start()
    {
        timer = Random.Range(150,MaxChanceOfShooting);
    }   

    //skyter etter så så lenge etter 
    void FixedUpdate()
    {

        timer--;
        if (timer <= 0){
            Shoot();
            timer = Random.Range(100,MaxChanceOfShooting);
        }

    }
    // det som gjør at bullet skyet
    void Shoot(){
        Instantiate(Bullets, Firepoint.position, Firepoint.rotation);
    }
}
