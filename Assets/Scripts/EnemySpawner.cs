using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate;

    private int rndx;
    private int rndy;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnRate, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        rndx = Random.Range(-12, 12);
        rndy = Random.Range(-1, 2);

    }

    private void Spawn()
    {
        if (rndy <= 0)
        {
            rndy = -7;
        }
        else rndy = 7;

        Instantiate(enemyPrefab, transform.position, Quaternion.identity);

        //Change();
        transform.position=new Vector3(rndx, rndy, transform.position.z);
    }
}
