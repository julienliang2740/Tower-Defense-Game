using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemies : MonoBehaviour {
    
    public GameObject theEnemy;

    private int enemyCount = 0;
    private float timer = 0;

    public int maxEnemyCount;
    public float spawnFrequency;

    public float minRadius;
    public float maxRadius;

    void Start() {}

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > spawnFrequency && enemyCount < maxEnemyCount)
        {
            float angle = Random.Range(0.0f, 2.0f * Mathf.PI);
            float r = Random.Range(minRadius, maxRadius);
            float x = Mathf.Cos(angle) * r;
            float z = Mathf.Sin(angle) * r;

            Instantiate(theEnemy, new Vector3(x, 2, z), Quaternion.identity);

            timer = 0;
            enemyCount++;

        }
    }

}
