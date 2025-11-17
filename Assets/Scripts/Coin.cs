using System.Runtime.CompilerServices;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private GameManager gameManager;

    // This entire file is Rachel's Week 2 Task 2
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
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
            gameManager.AddScore(1);
            Destroy(this.gameObject);
        }
    }
}