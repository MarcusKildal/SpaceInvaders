using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //variabel
    private Rigidbody2D body;
    [SerializeField] private float speed;
    public bool shootDelay = false;
    public Transform Firepoint;
    public GameObject Bullets;


    //henter rididbody lager det til en variabel
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }


    //Bruker variablen jeg lagde til e bestemme hvilken vei å hastieten til min player
    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);

        //dette er det som skyter bullets hvor jeg også lagdet er tur false statment for å lage lit deley du vill ikke mere det men detter er for å ungå at de ikke kan spamme skyte knappen
        if(Input.GetKeyDown(KeyCode.Space) && shootDelay == false)
        {
            StartCoroutine(delay());
        }

    }


    //det som gjør deleyen.
    IEnumerator delay()
    {
        shootDelay = true;
        Instantiate(Bullets, Firepoint.position, Firepoint.rotation);
        yield return new WaitForSeconds(0.1f);
        shootDelay = false;
    }
}
