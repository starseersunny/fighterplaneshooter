using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyR : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    // Rachel Week 1 Task 2
    void Update()
    {
        transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * 1.5f);
        if (transform.position.x > 9f)
        {
            Destroy(this.gameObject);
        }
    }
}