using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repatRate = 2;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repatRate);
    }
    void SpawnObstacle ()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
