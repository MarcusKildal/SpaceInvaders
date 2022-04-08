using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    //sier at når jeg trykker på en button skal den sennde meg til en annen sense med nummeret 1 
    public void PlayGame(){
        SceneManager.LoadScene(1);
    }
    //når jeg trykker på denne knappen vil jeg bli KASTER UT AV SPILLE :)
    public void QuitGame(){
        Application.Quit();
    }
    
}
