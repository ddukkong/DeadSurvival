using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawnTime = 3f;
    public float curTime;
    public Transform[] spawnPoints;
    public GameObject enemy0;
    public GameObject enemy1;

    void Update()
    {
        if(curTime >= spawnTime)
        {
            int x =Random.Range(0, spawnPoints.Length);
            SpawnEnemy(x);
            
        }
        curTime += Time.deltaTime;

    }
    public void SpawnEnemy(int RanNum)
    { 
        curTime = 0;
        Instantiate(enemy0, spawnPoints[RanNum]);
        Instantiate(enemy1, spawnPoints[RanNum]);
    
    
    
    }











}
