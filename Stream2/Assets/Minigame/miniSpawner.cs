using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniSpawner : MonoBehaviour
{
    public GameObject[] sampahPrefab;
    public Transform[] spawnPosition;
    int randomSpawn, i;
    public float deltaSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, deltaSpawn);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Spawn()
    {
        Instantiate(sampahPrefab[Random.Range(0, sampahPrefab.Length)], spawnPosition[Random.Range(0, spawnPosition.Length)].position, Quaternion.identity);
    }
}
