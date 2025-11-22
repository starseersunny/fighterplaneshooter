using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour

{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    
    void Update()
    {
        transform.Translate(new Vector3(0, 2, 0) * Time.deltaTime * 3f);
         if (transform.position.y < -10f)
        {
            Destroy(this.gameObject);
        } 
    }

    private void OnTriggerEnter2D(Collider2D whatDidIHit)
    {
        if(whatDidIHit.tag == "Player")
        {
            gameManager.PlaySound(3);
            gameManager.AddScore(1);
            Destroy(this.gameObject);
        }
    }
}