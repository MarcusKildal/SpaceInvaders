using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    [SerializeField]
    Text score;
    public static int myScore;
    

    //henter bare komponent text fra unity
    void Start()
    {
        score = GetComponent<Text> ();
    }


    //første linjen sier bare hva som skal stå ved siden av text basert på hvilket tall jeg får
    //andre linen i denne funksjonen er egentlig unity sin egent script hvor den sier på score skal være i et annen SCENE (menuscene)
    void Update()
    {
        score.text = "Score: " + myScore;
        PlayerPrefs.SetInt("score", myScore);
    }


    //har en script fra earth filen som er på før game starter skal den kjørene denne funskjonen som gjør score til 0 på starten
    public void SetScore()
    {
       myScore = 0;
    }
}




