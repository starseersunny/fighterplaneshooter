using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject enemyOnePrefab;
    public GameObject enemyRPrefab;
    public GameObject enemyKPrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyOne", 1, 2);
        InvokeRepeating("CreateEnemyR", 3, 4);
        InvokeRepeating("CreateEnemyK", 5, 6);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }
    // Rachel Week 1 Task 2
    void CreateEnemyR()
    {
        Instantiate(enemyRPrefab, new Vector3(-9f, Random.Range(3f, 5.5f), 0), Quaternion.identity);
    }
    // Kaitlyn Week 1 Task 3
    void CreateEnemyK()
    {
        Instantiate(enemyKPrefab, new Vector3(9f, Random.Range(3f, 5.5f), 0), Quaternion.identity);
    }
}