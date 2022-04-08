using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EarthHealthBar : MonoBehaviour
{
    //variabel
    public Slider slider;
    public Gradient gradientcollor;
    public Image fill;



   // dette er health baren den ser på "health" fra earth å endre value på slideren med det
    public void SetHealth(int health)
    {
        slider.value = health;
        fill.color = gradientcollor.Evaluate(slider.normalizedValue);
        if (health == 0)
        {
            die();
        }
    }


    //når funskjonen die skjer blir earth destroya
    public void die()
    {
        Destroy(gameObject);
    }
}
