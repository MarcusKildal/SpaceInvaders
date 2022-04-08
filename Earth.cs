using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;


public class Earth : MonoBehaviour
{
    //variabel å legger healthbar fil script inn i dette (unity gjør dette ganske kult)
    public int health = 100;
    public EarthHealthBar healthbar;
    public UnityEvent setScore;

    void Start()
    {
        setScore.Invoke();
    }

    // mister liv å sier til min health bar script at min helath bar skal bli mindre den dør hvis den blir 0 (med andre ord objecte til earth blir borte)
    public void TakeDamage (int damage)
    {
        health -= damage;
        healthbar.SetHealth(health);

        if (health <= 0)
        {
            Die();
        }
    }


    //når funskjonen die skjer blir earth destroya
    void Die ()
    {
        Destroy(gameObject);
        PlayGame();
    }

    public void PlayGame(){
        SceneManager.LoadScene(0);
    }
}

