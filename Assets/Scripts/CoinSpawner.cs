using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject[] coins;
    public GameObject player;
    public GameObject[] enemies;
    public GameObject crystal;
    float coinTimer = 7.0f;
    float timer = 10.0f;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        coinTimer -= Time.deltaTime;
        if (coinTimer <= 0.01f)
        {
            SpawnCoins();
        }
        timer -= Time.deltaTime;
        if (timer <= 0.01f)
        {
            CrystalSpawner();

        }
	}

    void SpawnCoins()
    {
        Instantiate(coins[(Random.Range(0, coins.Length))], new Vector3(player.transform.position.x + 30, Random.Range(5, 12), 0), Quaternion.identity);
        coinTimer = (Random.Range(1.0f, 3.0f));
    }
    void SpawnEnemies()
    {
        Instantiate(enemies[(Random.Range(0, enemies.Length))], new Vector3(player.transform.position.x + 30, Random.Range(4, 12), 0), Quaternion.identity);
    }
    void CrystalSpawner()
    {
        Instantiate(crystal, new Vector3(player.transform.position.x + Random.Range(20, 50), 0.5f, 0), Quaternion.identity);
        timer = Random.Range(5.0f, 10.0f);
    }
}
