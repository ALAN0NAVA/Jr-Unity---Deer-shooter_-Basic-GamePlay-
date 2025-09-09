using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float XBound = 20.0f;
    private float ZBound = 30.0f;

    private float startDalay = 2.0f;
    private float uperSpawnInterval = 2.5f;
    private float rightSpawnInterval = 2.5f;
    private float leftSpawnInterval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("upperSpawn", startDalay, uperSpawnInterval);
        InvokeRepeating("rightSpawn", startDalay, rightSpawnInterval);
        InvokeRepeating("leftSpawn", startDalay, leftSpawnInterval);
    }

    // Update is called once per frame
    void upperSpawn()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
     //the position where will be spawn
        Vector3 spawnPos = new Vector3(Random.Range(-XBound+3, XBound-3), 0, ZBound);
     //spawn the object
        Instantiate(animalPrefabs[0], spawnPos, animalPrefabs[0].transform.rotation = Quaternion.Euler(0, 180, 0));
    }
    void rightSpawn()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //the position where will be spawn
        Vector3 spawnPos = new Vector3(XBound, 0, Random.Range(-ZBound+15, ZBound-8));
        //spawn the object
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, -90, 0));
    }
    void leftSpawn()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //the position where will be spawn
        Vector3 spawnPos = new Vector3(-XBound, 0, Random.Range(-ZBound+15, ZBound-8));
        //spawn the object
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 90, 0));
        
    }
}
