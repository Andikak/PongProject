using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolaaku : MonoBehaviour
{
    public int speed = 30;
    public Rigidbody2D ball;
    // Start is called before the first frame update
    void Start()
    {
        ball.velocity = new Vector2(-1,-1) * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.name=="Skanan" || other.collider.name=="Skiri"){
           StartCoroutine(jeda());
        }
    }
    IEnumerator jeda(){
        ball.velocity = Vector2.zero;
        ball.GetComponent<Transform>().position = Vector2.zero;
        yield return new WaitForSeconds(1);
        ball.velocity = new Vector2(-1,-1) * speed;
    }
}
