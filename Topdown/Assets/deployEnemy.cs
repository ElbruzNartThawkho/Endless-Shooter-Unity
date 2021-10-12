using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float respawnTime = 1f;
    void Start()
    {
        StartCoroutine(asteroidWave());
    }
    //private void LateUpdate()
    //{
    //    //respawnTime = Random.Range(0f, 1f);
    //}
    private void SpawnEnemy()
    {
        GameObject a = Instantiate(enemy);
        a.transform.position = new Vector2(Random.Range(-3.22f, 3.22f), 6);
    }
    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnEnemy();
        }
    }
}
