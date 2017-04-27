﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class EnemySpawner : NetworkBehaviour {

    public GameObject enemyPrefab;
    public int numberOfEnemies;

    public override void OnStartServer()
    {
        for(int i = 0;i<numberOfEnemies;i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-8.0f, 8), 0, Random.Range(-8, 8));
            Quaternion spawnRotation = Quaternion.Euler(0.0f, Random.Range(0.0f, 180f), 0);

            GameObject enemy = (GameObject)Instantiate(enemyPrefab, spawnPosition, spawnRotation);
            NetworkServer.Spawn(enemy);
        }
    }
}
