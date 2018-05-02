using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject[] coins;
    public GameObject player;
    float coinTimer = 7.0f;

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
	}

    void SpawnCoins()
    {
        Instantiate(coins[(Random.Range(0, coins.Length))], new Vector3(player.transform.position.x + 30, Random.Range(2, 8), 0), player.transform.rotation);
        coinTimer = (Random.Range(1.0f, 3.0f));
    }
}
