using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolaaku : MonoBehaviour
{
    // public int speed = 30;
    public Rigidbody2D ball;
    public Animation anim;
    public GameObject masterScript;
    public AudioSource hitEffect;
    // Start is called before the first frame update
    void Start()
    {
        int x = Random.Range(0, 2) * 2 - 1; // nilai x bisa bernilai 1 atau -1
        int y = Random.Range(0, 2) * 2 - 1; // nilai y bisa bernilai 1 atau -1
        int speed = Random.Range(25, 26); // nilai antara 20 - 25
        ball.velocity = new Vector2(x, y) * speed;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // if(ball.velocity.x > 0){ //bola bergerak kekanan
        //     ball.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        // }else{
        //     ball.GetComponent<Transform>().localScale = new Vector3(-1, 1, 1);
        // }

        //masih error scale ny tidak bisa diatur 1,1,0
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.name=="Skanan" || other.collider.name=="Skiri"){
           masterScript.GetComponent<ScoringScript>().UpdateScoring(other.collider.name);
            //menjeda bola setelah terkena tembok
           StartCoroutine(jeda()); //untukpindahketengah
        }
        if(other.collider.tag=="Player"){ //menambahkan sound ketika bola terkena papan
            hitEffect.Play();
        }
    }
    IEnumerator jeda(){
        ball.velocity = Vector2.zero;
        ball.GetComponent<Transform>().position = Vector2.zero;

        yield return new WaitForSeconds(1);
        
        int x = Random.Range(0, 2) * 2 - 1; // nilai x bisa bernilai 1 atau -1
        int y = Random.Range(0, 2) * 2 - 1; // nilai y bisa bernilai 1 atau -1
        int speed = Random.Range(20, 26); // nilai antara 20 - 25
        ball.velocity = new Vector2(x, y) * speed;
    }
}
