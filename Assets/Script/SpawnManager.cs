using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float spawnTime = 1f;
    public float BossSpawnTime = 5f;
    public float curTime;
    public float BosscurTime;
    public Transform[] spawnPoints;
    public GameObject enemy0;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;

    void Update()
    {
        if(curTime >= spawnTime)
        {
            int x =Random.Range(0, spawnPoints.Length);
            SpawnEnemy(x);
            
        }
        if(BosscurTime >= BossSpawnTime)
        {
            int x = Random.Range(0, spawnPoints.Length);
            BossSpawnEnemy(x);
        }
        curTime += Time.deltaTime;
        BosscurTime += Time.deltaTime;

    }
    public void SpawnEnemy(int RanNum)
    { 
        curTime = 0;
        Instantiate(enemy0, spawnPoints[RanNum]);
        Instantiate(enemy1, spawnPoints[RanNum]);
    }
    public void BossSpawnEnemy(int RanNum)
    {
        BosscurTime = 0;
        Instantiate(enemy2, spawnPoints[RanNum]);
        Instantiate(enemy3, spawnPoints[RanNum]);
    }











}
